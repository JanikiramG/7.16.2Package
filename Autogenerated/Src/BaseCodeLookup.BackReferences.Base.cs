namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: BaseCodeLookup

	/// <exclude/>
	public class BaseCodeLookup : Terrasoft.Configuration.BaseCodeLookup
	{

		#region Constructors: Public

		public BaseCodeLookup(UserConnection userConnection)
			: base(userConnection) {
		}

		public BaseCodeLookup(Terrasoft.Configuration.BaseCodeLookup source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

