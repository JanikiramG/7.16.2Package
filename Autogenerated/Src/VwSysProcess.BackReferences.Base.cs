namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwSysProcess

	/// <exclude/>
	public class VwSysProcess : Terrasoft.Configuration.VwSysProcess
	{

		#region Constructors: Public

		public VwSysProcess(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwSysProcess(Terrasoft.Configuration.VwSysProcess source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

