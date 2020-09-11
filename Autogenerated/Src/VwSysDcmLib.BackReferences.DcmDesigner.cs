namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwSysDcmLib

	/// <exclude/>
	public class VwSysDcmLib : Terrasoft.Configuration.VwSysDcmLib
	{

		#region Constructors: Public

		public VwSysDcmLib(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwSysDcmLib(Terrasoft.Configuration.VwSysDcmLib source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

