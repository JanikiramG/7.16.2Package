namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysProcessLog

	/// <exclude/>
	public class SysProcessLog : Terrasoft.Configuration.SysProcessLog
	{

		#region Constructors: Public

		public SysProcessLog(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysProcessLog(Terrasoft.Configuration.SysProcessLog source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SysProcessElementLog> SysProcessElementLogCollectionBySysProcess {
			get;
			set;
		}

		public IEnumerable<SysProcessEntity> SysProcessEntityCollectionBySysProcess {
			get;
			set;
		}

		public IEnumerable<SysProcessLog> SysProcessLogCollectionByParent {
			get;
			set;
		}

		public IEnumerable<SysProcessLogInFolder> SysProcessLogInFolderCollectionBySysProcessLog {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

