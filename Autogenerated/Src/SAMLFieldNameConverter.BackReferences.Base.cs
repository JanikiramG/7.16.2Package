namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SAMLFieldNameConverter

	/// <exclude/>
	public class SAMLFieldNameConverter : Terrasoft.Configuration.SAMLFieldNameConverter
	{

		#region Constructors: Public

		public SAMLFieldNameConverter(UserConnection userConnection)
			: base(userConnection) {
		}

		public SAMLFieldNameConverter(Terrasoft.Configuration.SAMLFieldNameConverter source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

