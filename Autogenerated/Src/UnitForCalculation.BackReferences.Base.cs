namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: UnitForCalculation

	/// <exclude/>
	public class UnitForCalculation : Terrasoft.Configuration.UnitForCalculation
	{

		#region Constructors: Public

		public UnitForCalculation(UserConnection userConnection)
			: base(userConnection) {
		}

		public UnitForCalculation(Terrasoft.Configuration.UnitForCalculation source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Salary> SalaryCollectionByUnitForCalculation {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

