namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysLicPackage

	/// <exclude/>
	public class SysLicPackage : Terrasoft.Configuration.SysLicPackage
	{

		#region Constructors: Public

		public SysLicPackage(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysLicPackage(Terrasoft.Configuration.SysLicPackage source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SysLic> SysLicCollectionBySysLicPackage {
			get;
			set;
		}

		public IEnumerable<SysLicUser> SysLicUserCollectionBySysLicPackage {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

