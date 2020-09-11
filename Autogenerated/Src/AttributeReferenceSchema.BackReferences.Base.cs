namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: AttributeReferenceSchema

	/// <exclude/>
	public class AttributeReferenceSchema : Terrasoft.Configuration.AttributeReferenceSchema
	{

		#region Constructors: Public

		public AttributeReferenceSchema(UserConnection userConnection)
			: base(userConnection) {
		}

		public AttributeReferenceSchema(Terrasoft.Configuration.AttributeReferenceSchema source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

