namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: Attribute

	/// <exclude/>
	public class Attribute : Terrasoft.Configuration.Attribute
	{

		#region Constructors: Public

		public Attribute(UserConnection userConnection)
			: base(userConnection) {
		}

		public Attribute(Terrasoft.Configuration.Attribute source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<AttributeReferenceSchema> AttributeReferenceSchemaCollectionByAttribute {
			get;
			set;
		}

		public IEnumerable<AttributeValue> AttributeValueCollectionByAttribute {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

