namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: AttributeValue

	/// <exclude/>
	public class AttributeValue : Terrasoft.Configuration.AttributeValue
	{

		#region Constructors: Public

		public AttributeValue(UserConnection userConnection)
			: base(userConnection) {
		}

		public AttributeValue(Terrasoft.Configuration.AttributeValue source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

