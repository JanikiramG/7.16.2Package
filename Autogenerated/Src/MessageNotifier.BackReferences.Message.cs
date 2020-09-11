namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: MessageNotifier

	/// <exclude/>
	public class MessageNotifier : Terrasoft.Configuration.MessageNotifier
	{

		#region Constructors: Public

		public MessageNotifier(UserConnection userConnection)
			: base(userConnection) {
		}

		public MessageNotifier(Terrasoft.Configuration.MessageNotifier source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<LeadMessageHistory> LeadMessageHistoryCollectionByMessageNotifier {
			get;
			set;
		}

		public IEnumerable<ListenerByNotifier> ListenerByNotifierCollectionByMessageNotifier {
			get;
			set;
		}

		public IEnumerable<MessageNotifier> MessageNotifierCollectionByAliasNotifier {
			get;
			set;
		}

		public IEnumerable<MessageNotifierBySection> MessageNotifierBySectionCollectionByMessageNotifier {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

