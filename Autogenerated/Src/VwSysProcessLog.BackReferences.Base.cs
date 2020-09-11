namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwSysProcessLog

	/// <exclude/>
	public class VwSysProcessLog : Terrasoft.Configuration.VwSysProcessLog
	{

		#region Constructors: Public

		public VwSysProcessLog(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwSysProcessLog(Terrasoft.Configuration.VwSysProcessLog source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<VwSysProcessElementLog> VwSysProcessElementLogCollectionBySysProcess {
			get;
			set;
		}

		public IEnumerable<VwSysProcessEntity> VwSysProcessEntityCollectionBySysProcess {
			get;
			set;
		}

		public IEnumerable<VwSysProcessLog> VwSysProcessLogCollectionByParent {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

