namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwProcessLib

	/// <exclude/>
	public class VwProcessLib : Terrasoft.Configuration.VwProcessLib
	{

		#region Constructors: Public

		public VwProcessLib(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwProcessLib(Terrasoft.Configuration.VwProcessLib source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<VwSubProcessInProcess> VwSubProcessInProcessCollectionByActiveSubProcess {
			get;
			set;
		}

		public IEnumerable<VwSubProcessInProcess> VwSubProcessInProcessCollectionByHostProcess {
			get;
			set;
		}

		public IEnumerable<VwSubProcessInProcess> VwSubProcessInProcessCollectionByParentProcess {
			get;
			set;
		}

		public IEnumerable<VwSubProcessInProcess> VwSubProcessInProcessCollectionByParentSubProcess {
			get;
			set;
		}

		public IEnumerable<VwSubProcessInProcess> VwSubProcessInProcessCollectionBySubProcess {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

