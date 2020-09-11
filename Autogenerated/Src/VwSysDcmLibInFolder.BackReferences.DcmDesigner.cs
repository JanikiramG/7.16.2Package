namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwSysDcmLibInFolder

	/// <exclude/>
	public class VwSysDcmLibInFolder : Terrasoft.Configuration.VwSysDcmLibInFolder
	{

		#region Constructors: Public

		public VwSysDcmLibInFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwSysDcmLibInFolder(Terrasoft.Configuration.VwSysDcmLibInFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

