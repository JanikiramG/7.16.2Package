namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwProcessLibInFolder

	/// <exclude/>
	public class VwProcessLibInFolder : Terrasoft.Configuration.VwProcessLibInFolder
	{

		#region Constructors: Public

		public VwProcessLibInFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwProcessLibInFolder(Terrasoft.Configuration.VwProcessLibInFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

