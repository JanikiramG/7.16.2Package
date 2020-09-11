namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwSysSetting

	/// <exclude/>
	public class VwSysSetting : Terrasoft.Configuration.VwSysSetting
	{

		#region Constructors: Public

		public VwSysSetting(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwSysSetting(Terrasoft.Configuration.VwSysSetting source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

