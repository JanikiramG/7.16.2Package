namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: MainParam

	/// <exclude/>
	public class MainParam : Terrasoft.Configuration.MainParam
	{

		#region Constructors: Public

		public MainParam(UserConnection userConnection)
			: base(userConnection) {
		}

		public MainParam(Terrasoft.Configuration.MainParam source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<CommandParams> CommandParamsCollectionByMainParam {
			get;
			set;
		}

		public IEnumerable<Macros> MacrosCollectionByMainParam {
			get;
			set;
		}

		public IEnumerable<MainParamLczOld> MainParamLczOldCollectionByRecord {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

