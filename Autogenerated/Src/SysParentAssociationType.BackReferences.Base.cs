namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysParentAssociationType

	/// <exclude/>
	public class SysParentAssociationType : Terrasoft.Configuration.SysParentAssociationType
	{

		#region Constructors: Public

		public SysParentAssociationType(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysParentAssociationType(Terrasoft.Configuration.SysParentAssociationType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SysModuleDetailParentAssc> SysModuleDetailParentAsscCollectionBySysParentAssociationType {
			get;
			set;
		}

		public IEnumerable<SysModuleEditDetailParentAssc> SysModuleEditDetailParentAsscCollectionBySysParentAssociationType {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

