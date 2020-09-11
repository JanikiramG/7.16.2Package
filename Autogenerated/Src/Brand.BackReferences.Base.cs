namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: Brand

	/// <exclude/>
	public class Brand : Terrasoft.Configuration.Brand
	{

		#region Constructors: Public

		public Brand(UserConnection userConnection)
			: base(userConnection) {
		}

		public Brand(Terrasoft.Configuration.Brand source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

