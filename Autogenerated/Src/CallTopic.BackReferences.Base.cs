namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: CallTopic

	/// <exclude/>
	public class CallTopic : Terrasoft.Configuration.CallTopic
	{

		#region Constructors: Public

		public CallTopic(UserConnection userConnection)
			: base(userConnection) {
		}

		public CallTopic(Terrasoft.Configuration.CallTopic source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

