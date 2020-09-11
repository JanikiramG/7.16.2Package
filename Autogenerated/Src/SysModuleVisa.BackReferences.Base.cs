namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysModuleVisa

	/// <exclude/>
	public class SysModuleVisa : Terrasoft.Configuration.SysModuleVisa
	{

		#region Constructors: Public

		public SysModuleVisa(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysModuleVisa(Terrasoft.Configuration.SysModuleVisa source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Portal_SysModule> Portal_SysModuleCollectionBySysModuleVisa {
			get;
			set;
		}

		public IEnumerable<SysModule> SysModuleCollectionBySysModuleVisa {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

