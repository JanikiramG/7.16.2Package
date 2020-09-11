namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SpecificationInObject

	/// <exclude/>
	public class SpecificationInObject : Terrasoft.Configuration.SpecificationInObject
	{

		#region Constructors: Public

		public SpecificationInObject(UserConnection userConnection)
			: base(userConnection) {
		}

		public SpecificationInObject(Terrasoft.Configuration.SpecificationInObject source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

