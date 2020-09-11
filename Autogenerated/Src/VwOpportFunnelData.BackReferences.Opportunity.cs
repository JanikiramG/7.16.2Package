namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwOpportFunnelData

	/// <exclude/>
	public class VwOpportFunnelData : Terrasoft.Configuration.VwOpportFunnelData
	{

		#region Constructors: Public

		public VwOpportFunnelData(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwOpportFunnelData(Terrasoft.Configuration.VwOpportFunnelData source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

