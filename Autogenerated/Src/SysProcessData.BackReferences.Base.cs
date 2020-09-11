namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysProcessData

	/// <exclude/>
	public class SysProcessData : Terrasoft.Configuration.SysProcessData
	{

		#region Constructors: Public

		public SysProcessData(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysProcessData(Terrasoft.Configuration.SysProcessData source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SysProcessData> SysProcessDataCollectionByParent {
			get;
			set;
		}

		public IEnumerable<SysProcessElementData> SysProcessElementDataCollectionBySysProcess {
			get;
			set;
		}

		public IEnumerable<VwProcessDashboard> VwProcessDashboardCollectionByProcessData {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

