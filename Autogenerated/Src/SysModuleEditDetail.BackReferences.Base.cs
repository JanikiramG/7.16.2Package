namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysModuleEditDetail

	/// <exclude/>
	public class SysModuleEditDetail : Terrasoft.Configuration.SysModuleEditDetail
	{

		#region Constructors: Public

		public SysModuleEditDetail(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysModuleEditDetail(Terrasoft.Configuration.SysModuleEditDetail source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SysModuleEditDetailParentAssc> SysModuleEditDetailParentAsscCollectionBySysModuleEditDetail {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

