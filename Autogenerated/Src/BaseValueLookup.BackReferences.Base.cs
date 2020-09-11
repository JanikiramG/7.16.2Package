namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: BaseValueLookup

	/// <exclude/>
	public class BaseValueLookup : Terrasoft.Configuration.BaseValueLookup
	{

		#region Constructors: Public

		public BaseValueLookup(UserConnection userConnection)
			: base(userConnection) {
		}

		public BaseValueLookup(Terrasoft.Configuration.BaseValueLookup source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

