namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: Territory

	/// <exclude/>
	public class Territory : Terrasoft.Configuration.Territory
	{

		#region Constructors: Public

		public Territory(UserConnection userConnection)
			: base(userConnection) {
		}

		public Territory(Terrasoft.Configuration.Territory source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

