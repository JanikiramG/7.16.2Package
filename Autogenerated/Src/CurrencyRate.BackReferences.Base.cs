namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: CurrencyRate

	/// <exclude/>
	public class CurrencyRate : Terrasoft.Configuration.CurrencyRate
	{

		#region Constructors: Public

		public CurrencyRate(UserConnection userConnection)
			: base(userConnection) {
		}

		public CurrencyRate(Terrasoft.Configuration.CurrencyRate source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

