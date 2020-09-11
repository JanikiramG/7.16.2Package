namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: MessageListener

	/// <exclude/>
	public class MessageListener : Terrasoft.Configuration.MessageListener
	{

		#region Constructors: Public

		public MessageListener(UserConnection userConnection)
			: base(userConnection) {
		}

		public MessageListener(Terrasoft.Configuration.MessageListener source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<ListenerByNotifier> ListenerByNotifierCollectionByMessageListener {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

