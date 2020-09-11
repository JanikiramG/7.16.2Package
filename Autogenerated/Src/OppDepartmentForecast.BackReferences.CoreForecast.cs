namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: OppDepartmentForecast

	/// <exclude/>
	public class OppDepartmentForecast : Terrasoft.Configuration.OppDepartmentForecast
	{

		#region Constructors: Public

		public OppDepartmentForecast(UserConnection userConnection)
			: base(userConnection) {
		}

		public OppDepartmentForecast(Terrasoft.Configuration.OppDepartmentForecast source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

