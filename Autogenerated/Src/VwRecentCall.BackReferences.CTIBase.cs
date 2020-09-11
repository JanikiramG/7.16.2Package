namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwRecentCall

	/// <exclude/>
	public class VwRecentCall : Terrasoft.Configuration.VwRecentCall
	{

		#region Constructors: Public

		public VwRecentCall(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwRecentCall(Terrasoft.Configuration.VwRecentCall source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

