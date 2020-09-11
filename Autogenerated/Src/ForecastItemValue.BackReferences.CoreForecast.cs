namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ForecastItemValue

	/// <exclude/>
	public class ForecastItemValue : Terrasoft.Configuration.ForecastItemValue
	{

		#region Constructors: Public

		public ForecastItemValue(UserConnection userConnection)
			: base(userConnection) {
		}

		public ForecastItemValue(Terrasoft.Configuration.ForecastItemValue source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

