namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IForecastCalculatorSchema

	/// <exclude/>
	public class IForecastCalculatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IForecastCalculatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IForecastCalculatorSchema(IForecastCalculatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7ec2b165-5e49-4298-bc0b-1de925207e9f");
			Name = "IForecastCalculator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,81,59,107,3,49,12,158,19,200,127,16,201,210,44,103,232,216,166,183,4,10,25,2,29,74,119,213,39,7,131,31,135,100,23,66,201,127,175,227,228,122,215,38,224,65,242,247,146,173,128,158,164,71,77,240,78,204,40,209,164,102,27,131,177,135,204,152,108,12,205,107,100,210,40,233,227,17,190,23,243,89,57,43,166,67,65,96,23,18,177,41,218,39,216,13,172,45,58,157,29,166,200,139,121,161,42,165,96,35,217,123,228,99,123,237,71,10,216,193,1,76,233,204,213,3,116,116,217,7,105,6,3,53,113,232,243,167,179,122,162,188,27,61,59,143,122,147,254,39,158,228,127,32,124,161,203,84,99,111,115,47,55,61,50,122,8,229,211,94,150,181,166,50,134,44,219,183,223,186,217,168,10,140,26,166,148,57,72,187,143,157,53,150,58,232,167,228,1,61,211,167,47,169,142,50,78,251,112,7,28,141,214,207,69,127,170,95,190,162,208,93,22,84,183,117,250,1,35,91,209,232,226,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7ec2b165-5e49-4298-bc0b-1de925207e9f"));
		}

		#endregion

	}

	#endregion

}

