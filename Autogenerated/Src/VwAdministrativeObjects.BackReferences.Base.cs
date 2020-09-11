namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwAdministrativeObjects

	/// <exclude/>
	public class VwAdministrativeObjects : Terrasoft.Configuration.VwAdministrativeObjects
	{

		#region Constructors: Public

		public VwAdministrativeObjects(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwAdministrativeObjects(Terrasoft.Configuration.VwAdministrativeObjects source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

