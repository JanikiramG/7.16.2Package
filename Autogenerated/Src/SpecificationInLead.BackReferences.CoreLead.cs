namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SpecificationInLead

	/// <exclude/>
	public class SpecificationInLead : Terrasoft.Configuration.SpecificationInLead
	{

		#region Constructors: Public

		public SpecificationInLead(UserConnection userConnection)
			: base(userConnection) {
		}

		public SpecificationInLead(Terrasoft.Configuration.SpecificationInLead source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

