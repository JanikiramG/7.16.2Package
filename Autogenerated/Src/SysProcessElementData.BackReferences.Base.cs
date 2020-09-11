namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysProcessElementData

	/// <exclude/>
	public class SysProcessElementData : Terrasoft.Configuration.SysProcessElementData
	{

		#region Constructors: Public

		public SysProcessElementData(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysProcessElementData(Terrasoft.Configuration.SysProcessElementData source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<EntryPoint> EntryPointCollectionBySysProcessElementData {
			get;
			set;
		}

		public IEnumerable<SysEntityCommonPrcEl> SysEntityCommonPrcElCollectionByProcessElement {
			get;
			set;
		}

		public IEnumerable<SysProcessIntermediateEvent> SysProcessIntermediateEventCollectionBySysProcessElement {
			get;
			set;
		}

		public IEnumerable<VwProcessDashboard> VwProcessDashboardCollectionByProcessElement {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

