namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysModuleDetail

	/// <exclude/>
	public class SysModuleDetail : Terrasoft.Configuration.SysModuleDetail
	{

		#region Constructors: Public

		public SysModuleDetail(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysModuleDetail(Terrasoft.Configuration.SysModuleDetail source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SysModuleDetailLczOld> SysModuleDetailLczOldCollectionByRecord {
			get;
			set;
		}

		public IEnumerable<SysModuleDetailParentAssc> SysModuleDetailParentAsscCollectionBySysModuleDetail {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

