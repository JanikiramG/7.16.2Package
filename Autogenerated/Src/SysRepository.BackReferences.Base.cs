namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysRepository

	/// <exclude/>
	public class SysRepository : Terrasoft.Configuration.SysRepository
	{

		#region Constructors: Public

		public SysRepository(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysRepository(Terrasoft.Configuration.SysRepository source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SysPackage> SysPackageCollectionBySysRepository {
			get;
			set;
		}

		public IEnumerable<SysRepositoryUser> SysRepositoryUserCollectionBySysRepository {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

