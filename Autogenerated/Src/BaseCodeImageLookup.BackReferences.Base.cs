namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: BaseCodeImageLookup

	/// <exclude/>
	public class BaseCodeImageLookup : Terrasoft.Configuration.BaseCodeImageLookup
	{

		#region Constructors: Public

		public BaseCodeImageLookup(UserConnection userConnection)
			: base(userConnection) {
		}

		public BaseCodeImageLookup(Terrasoft.Configuration.BaseCodeImageLookup source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

