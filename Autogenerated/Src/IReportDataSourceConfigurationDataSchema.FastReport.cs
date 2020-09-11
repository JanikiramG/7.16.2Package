namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IReportDataSourceConfigurationDataSchema

	/// <exclude/>
	public class IReportDataSourceConfigurationDataSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IReportDataSourceConfigurationDataSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IReportDataSourceConfigurationDataSchema(IReportDataSourceConfigurationDataSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0c43a542-85de-4648-9651-f6d4fe333f34");
			Name = "IReportDataSourceConfigurationData";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0005402e-c4df-422a-beab-65ef1e6175ad");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,143,65,10,131,48,16,69,215,10,222,97,192,189,7,168,75,75,139,155,34,181,23,72,117,12,1,77,100,102,178,40,210,187,55,38,80,176,171,46,255,155,249,127,254,88,181,32,175,106,64,120,32,145,98,55,73,213,56,59,25,237,73,137,113,182,186,227,234,72,140,213,213,69,177,36,85,228,91,145,103,158,3,133,254,197,130,75,93,228,129,148,132,58,120,160,153,21,243,9,218,180,125,86,162,122,231,105,192,67,242,142,163,107,245,207,217,12,96,172,32,77,123,149,127,124,217,22,189,223,147,29,185,21,67,79,12,119,187,24,152,230,87,111,70,104,71,216,64,163,212,240,78,148,133,246,238,183,240,253,207,164,68,59,166,200,168,19,61,194,192,62,65,204,210,157,55,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0c43a542-85de-4648-9651-f6d4fe333f34"));
		}

		#endregion

	}

	#endregion

}

