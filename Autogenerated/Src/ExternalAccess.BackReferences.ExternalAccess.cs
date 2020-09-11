namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ExternalAccess

	/// <exclude/>
	public class ExternalAccess : Terrasoft.Configuration.ExternalAccess
	{

		#region Constructors: Public

		public ExternalAccess(UserConnection userConnection)
			: base(userConnection) {
		}

		public ExternalAccess(Terrasoft.Configuration.ExternalAccess source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<ExternalAccessFile> ExternalAccessFileCollectionByExternalAccess {
			get;
			set;
		}

		public IEnumerable<ExternalAccessInFolder> ExternalAccessInFolderCollectionByExternalAccess {
			get;
			set;
		}

		public IEnumerable<ExternalAccessInTag> ExternalAccessInTagCollectionByEntity {
			get;
			set;
		}

		public IEnumerable<SysIsolatedRecord> SysIsolatedRecordCollectionByExternalAccess {
			get;
			set;
		}

		public IEnumerable<SysUserSession> SysUserSessionCollectionByExternalAccess {
			get;
			set;
		}

		public IEnumerable<VwIsolatedRecord> VwIsolatedRecordCollectionByExternalAccess {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

