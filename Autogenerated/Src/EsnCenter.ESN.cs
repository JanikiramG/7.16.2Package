namespace Terrasoft.Configuration.ESN
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Security;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Nui.ServiceModel.DataContract;

	#region  Class: EsnCenter

	/// <inheritdoc />
	[DefaultBinding(typeof(IEsnCenter))]
	public class EsnCenter : IEsnCenter
	{
		#region Constants: Private

		private readonly IEsnLikeRepository _likeRepository;
		private readonly IEsnMessageReader _messageReader;
		private readonly IEsnMessageRedactor _messageRedactor;
		private readonly IEsnSecurityEngine _esnSecurityEngine;

		#endregion

		#region Constructors: Public

		public EsnCenter(IEsnLikeRepository esnLikeRepository, IEsnMessageReader esnMessageReader,
				IEsnMessageRedactor esnMessageRedactor, IEsnSecurityEngine esnSecurityEngine) {
			_likeRepository = esnLikeRepository;
			_messageReader = esnMessageReader;
			_messageRedactor = esnMessageRedactor;
			_esnSecurityEngine = esnSecurityEngine;
		}

		#endregion

		#region Methods: Private

		private LookupColumnValue GetParent(Entity entity) {
			var parentId = entity.GetTypedColumnValue<Guid>("ParentId");
			return parentId == Guid.Empty
				? null
				: new LookupColumnValue { Value = parentId.ToString() };
		}

		private LookupColumnValue GetCreatedBy(Entity entity) {
			return new LookupColumnValue {
				DisplayValue = entity.GetTypedColumnValue<string>("CreatedByName"),
				PrimaryImageValue = entity.GetTypedColumnValue<Guid>("CreatedByPrimaryImage") == Guid.Empty
					? string.Empty
					: entity.GetTypedColumnValue<string>("CreatedByPrimaryImage"),
				Value = entity.GetTypedColumnValue<string>("CreatedById")
			};
		}

		#endregion

		#region Methods: Protected

		/// <summary>
		/// Create DTO for response.
		/// </summary>
		/// <param name="entity">Instance of <see cref="Terrasoft.Core.Entities.Entity" />.</param>
		/// <returns>Instance of <see cref="Terrasoft.Configuration.ESN.EsnLikeDTO" />.</returns>
		protected virtual EsnLikeDTO CreateEsnLikeDTO(Entity entity) => new EsnLikeDTO {
			Id = entity.PrimaryColumnValue,
			SocialMessageId = entity.GetTypedColumnValue<Guid>("SocialMessageId"),
			UserId = entity.GetTypedColumnValue<Guid>("UserId"),
			ContactId = entity.GetTypedColumnValue<Guid>("CreatedById"),
			ContactName = entity.GetColumnValue("CreatedByName").ToString(),
			ContactPrimaryImageId = entity.GetTypedColumnValue<Guid>("CreatedByPrimaryImage")
		};

		/// <summary>
		/// Create message DTO for response.
		/// </summary>
		/// <param name="entity">Instance of <see cref="Entity" />.</param>
		/// <returns>Instance of <see cref="EsnReadMessageDTO" />.</returns>
		protected virtual EsnReadMessageDTO CreateEsnMessageDTO(Entity entity) => new EsnReadMessageDTO {
			Id = entity.PrimaryColumnValue,
			Color = entity.GetTypedColumnValue<string>("Color"),
			CommentCount = entity.GetTypedColumnValue<int>("CommentCount"),
			CreatedBy = GetCreatedBy(entity),
			CreatedOn = GetSerializedDateTime(entity.GetTypedColumnValue<DateTime>("CreatedOn")),
			EntityId = entity.GetTypedColumnValue<Guid>("EntityId"),
			EntitySchemaName = entity.GetTypedColumnValue<string>("EntitySchemaName"),
			EntitySchemaCaption = entity.GetTypedColumnValue<string>("EntitySchemaCaption"),
			LinkPreviewData = entity.FindEntityColumnValue("LinkPreviewData") != null
						? entity.GetBytesValue("LinkPreviewData")
						: null,
			EntitySchemaUId = entity.GetTypedColumnValue<Guid>("EntitySchemaUId"),
			LastActionOn = GetSerializedDateTime(entity.GetTypedColumnValue<DateTime>("LastActionOn")),
			LikeCount = entity.GetTypedColumnValue<int>("LikeCount"),
			Message = entity.GetTypedColumnValue<string>("Message"),
			Parent = GetParent(entity),
		};

		/// <summary>
		/// Create serialized date in Utc time zone.
		/// </summary>
		protected string GetSerializedDateTime(DateTime dateTime) {
			return DateTimeDataValueType.Serialize(dateTime, TimeZoneInfo.Utc);
		}

		#endregion

		#region Methods: Public

		/// <inheritdoc />
		public IEnumerable<EsnLikeDTO> GetMessageLikesForUser(Guid userId, IEnumerable<Guid> messageIds) =>
				_likeRepository.GetUserLikesByMessages(userId, messageIds).Select(CreateEsnLikeDTO);

		/// <inheritdoc />
		public IEnumerable<EsnLikeDTO> GetWhoLikedMessage(Guid messageId) =>
				_likeRepository.GetWhoLikedMessage(messageId).Select(CreateEsnLikeDTO);

		/// <inheritdoc />
		public Guid LikeMessage(Guid userId, Guid messageId) => _likeRepository.AddLike(userId, messageId);

		/// <inheritdoc />
		public bool UnLikeMessage(Guid userId, Guid messageId) => _likeRepository.DeleteLike(userId, messageId);

		/// <inheritdoc />
		public IEnumerable<EsnReadMessageDTO> ReadComments(Guid schemaUId, Guid entityId, Guid messageId) {
			if (_esnSecurityEngine.CanReadEntityMessage(schemaUId, entityId)) {
				return _messageReader.ReadComments(messageId).Select(CreateEsnMessageDTO);
			}
			throw new SecurityException(string.Format(
					new LocalizableString("Terrasoft.Core",
							"DBSecurityEngine.Exception.CurrentUserHasNotRightsForObject"), "SocialMessage"));
		}

		/// <inheritdoc />
		public EsnReadMessageDTO ReadMessage(Guid schemaUId, Guid entityId, Guid messageId) {
			if (_esnSecurityEngine.CanReadEntityMessage(schemaUId, entityId)) {
				return CreateEsnMessageDTO(_messageReader.ReadMessage(messageId));
			}
			throw new SecurityException(string.Format(
					new LocalizableString("Terrasoft.Core",
							"DBSecurityEngine.Exception.CurrentUserHasNotRightsForObject"), "SocialMessage"));
		}

		/// <inheritdoc />
		public IEnumerable<EsnReadMessageDTO> ReadEntityMessage(Guid schemaUId, Guid entityId,
				EsnReadMessageOptions options) {
			if (_esnSecurityEngine.CanReadEntityMessage(schemaUId, entityId)) {
				return _messageReader.ReadEntityMessage(entityId, options).Select(CreateEsnMessageDTO);
			}
			throw new SecurityException(string.Format(
					new LocalizableString("Terrasoft.Core",
							"DBSecurityEngine.Exception.CurrentUserHasNotRightsForObject"), "SocialMessage"));
		}

		/// <inheritdoc />
		public IEnumerable<EsnReadMessageDTO> ReadFeedMessage(EsnReadMessageOptions readOptions) {
			var messages = new List<EsnReadMessageDTO>();
			var readOptionLocal = new EsnReadMessageOptions {
				SortedBy = readOptions.SortedBy,
				ReadMessageCount = readOptions.ReadMessageCount,
				OffsetDate = readOptions.OffsetDate
			};
			var sortedColumnName = readOptionLocal.SortedBy.ToString();
			do {
				var messagesFromDb = _messageReader.ReadFeedMessage(readOptionLocal);
				foreach (var message in messagesFromDb) {
					readOptionLocal.OffsetDate = message.GetTypedColumnValue<DateTime>(sortedColumnName);
					var entityId = message.GetTypedColumnValue<Guid>("EntityId");
					var entitySchemaUId = message.GetTypedColumnValue<Guid>("EntitySchemaUId");

					if (_esnSecurityEngine.CanReadEntityMessage(entitySchemaUId, entityId)) {
						messages.Add(CreateEsnMessageDTO(message));
						if (messages.Count == readOptions.ReadMessageCount) {
							break;
						}
					}
				}
				if (messagesFromDb.Count() != readOptions.ReadMessageCount) {
					break;
				}
			} while (messages.Count < readOptions.ReadMessageCount);
			return messages;
		}

		/// <inheritdoc />
		public Guid PostMessage(EsnWriteMessageDTO messageData) {
			if (_esnSecurityEngine.CanCreateMessage(messageData.SchemaUId, messageData.EntityId)) {
				return _messageRedactor.PostMessage(messageData);
			}
			throw new SecurityException(string.Format(
					new LocalizableString("Terrasoft.Core",
							"DBSecurityEngine.Exception.CurrentUserHasNotRightsForObject"), "SocialMessage"));
		}

		/// <inheritdoc />
		public Guid PostComment(Guid messageId, EsnWriteMessageDTO commentData) {
			if (_esnSecurityEngine.CanCreateComment(commentData.SchemaUId, commentData.EntityId)) {
				return _messageRedactor.PostComment(messageId, commentData);
			}
			throw new SecurityException(string.Format(
					new LocalizableString("Terrasoft.Core",
							"DBSecurityEngine.Exception.CurrentUserHasNotRightsForObject"), "SocialMessage"));
		}


		/// <inheritdoc />
		public bool EditMessage(Guid messageId, EsnWriteMessageDTO messageData) {
			var messageEntity = _messageReader.ReadMessageAllColumnsEntity(messageId);
			var messageAuthorId = messageEntity.GetTypedColumnValue<Guid>("CreatedById");
			if (_esnSecurityEngine.CanEditPost(messageData.SchemaUId, messageData.EntityId, messageAuthorId)) {
				return _messageRedactor.EditMessage(messageEntity, messageData.Message);
			}
			throw new SecurityException(string.Format(
					new LocalizableString("Terrasoft.Core",
							"DBSecurityEngine.Exception.CurrentUserHasNotRightsForObject"), "SocialMessage"));
		}

		/// <inheritdoc />
		public bool EditComment(Guid commentId, EsnWriteMessageDTO commentData) {
			var commentEntity = _messageReader.ReadMessageAllColumnsEntity(commentId);
			var commentAuthorId = commentEntity.GetTypedColumnValue<Guid>("CreatedById");
			if (_esnSecurityEngine.CanEditPost(commentData.SchemaUId, commentData.EntityId, commentAuthorId)) {
				return _messageRedactor.EditComment(commentEntity, commentData.Message);
			}
			throw new SecurityException(string.Format(
					new LocalizableString("Terrasoft.Core",
							"DBSecurityEngine.Exception.CurrentUserHasNotRightsForObject"), "SocialMessage"));
		}

		/// <inheritdoc />
		public bool DeleteMessage(Guid schemaUId, Guid entityId, Guid messageId) {
			var messageEntity = _messageReader.ReadMessageAllColumnsEntity(messageId);
			var messageAuthorId = messageEntity.GetTypedColumnValue<Guid>("CreatedById");
			if (_esnSecurityEngine.CanDeletePost(schemaUId, entityId, messageAuthorId)) {
				return _messageRedactor.DeleteMessage(messageEntity);
			}
			throw new SecurityException(string.Format(
					new LocalizableString("Terrasoft.Core",
							"DBSecurityEngine.Exception.CurrentUserHasNotRightsForObject"), "SocialMessage"));
		}

		/// <inheritdoc />
		public bool DeleteComment(Guid schemaUId, Guid entityId, Guid commentId) {
			var commentEntity = _messageReader.ReadMessageAllColumnsEntity(commentId);
			var commentAuthorId = commentEntity.GetTypedColumnValue<Guid>("CreatedById");
			if (_esnSecurityEngine.CanDeletePost(schemaUId, entityId, commentAuthorId)) {
				return _messageRedactor.DeleteComment(commentEntity);
			}
			throw new SecurityException(string.Format(
					new LocalizableString("Terrasoft.Core",
							"DBSecurityEngine.Exception.CurrentUserHasNotRightsForObject"), "SocialMessage"));
		}

		#endregion
	}

	#endregion
}

