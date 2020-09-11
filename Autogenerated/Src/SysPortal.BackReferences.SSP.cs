namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysPortal

	/// <exclude/>
	public class SysPortal : Terrasoft.Configuration.SysPortal
	{

		#region Constructors: Public

		public SysPortal(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysPortal(Terrasoft.Configuration.SysPortal source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SysModuleEntityInPortal> SysModuleEntityInPortalCollectionBySysPortal {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

