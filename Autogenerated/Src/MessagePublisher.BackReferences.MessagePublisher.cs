namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: MessagePublisher

	/// <exclude/>
	public class MessagePublisher : Terrasoft.Configuration.MessagePublisher
	{

		#region Constructors: Public

		public MessagePublisher(UserConnection userConnection)
			: base(userConnection) {
		}

		public MessagePublisher(Terrasoft.Configuration.MessagePublisher source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<MessagePublisherBySection> MessagePublisherBySectionCollectionByMessagePublisher {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

