namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: BaseLookup

	/// <exclude/>
	public class BaseLookup : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public BaseLookup(UserConnection userConnection)
			: base(userConnection) {
		}

		public BaseLookup(Terrasoft.Configuration.BaseLookup source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

