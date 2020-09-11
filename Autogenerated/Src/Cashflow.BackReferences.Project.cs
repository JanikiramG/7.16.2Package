namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: Cashflow

	/// <exclude/>
	public class Cashflow : Terrasoft.Configuration.Cashflow
	{

		#region Constructors: Public

		public Cashflow(UserConnection userConnection)
			: base(userConnection) {
		}

		public Cashflow(Terrasoft.Configuration.Cashflow source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

