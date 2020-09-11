namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ListenerByNotifier

	/// <exclude/>
	public class ListenerByNotifier : Terrasoft.Configuration.ListenerByNotifier
	{

		#region Constructors: Public

		public ListenerByNotifier(UserConnection userConnection)
			: base(userConnection) {
		}

		public ListenerByNotifier(Terrasoft.Configuration.ListenerByNotifier source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

