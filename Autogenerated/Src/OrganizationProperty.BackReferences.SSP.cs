namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: OrganizationProperty

	/// <exclude/>
	public class OrganizationProperty : Terrasoft.Configuration.OrganizationProperty
	{

		#region Constructors: Public

		public OrganizationProperty(UserConnection userConnection)
			: base(userConnection) {
		}

		public OrganizationProperty(Terrasoft.Configuration.OrganizationProperty source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

