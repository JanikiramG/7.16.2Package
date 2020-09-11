namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ReportDataSourceMetadataSchema

	/// <exclude/>
	public class ReportDataSourceMetadataSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ReportDataSourceMetadataSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ReportDataSourceMetadataSchema(ReportDataSourceMetadataSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0f7879a2-86ee-4454-873c-c2e2e1511084");
			Name = "ReportDataSourceMetadata";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0005402e-c4df-422a-beab-65ef1e6175ad");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,143,65,10,194,48,16,69,215,45,244,14,3,238,123,0,187,84,20,23,74,81,47,48,166,99,9,180,73,200,76,22,82,188,187,105,34,66,65,116,51,240,255,188,249,252,49,56,18,59,84,4,87,242,30,217,222,165,222,88,115,215,125,240,40,218,154,250,76,206,122,209,166,175,119,200,146,85,85,78,85,89,4,142,46,92,30,44,52,54,85,25,157,149,167,62,222,192,102,64,230,53,100,120,139,130,23,27,188,162,35,9,118,81,37,214,133,219,160,21,168,25,253,65,22,83,162,63,209,173,183,142,98,31,138,249,109,138,200,251,119,220,62,232,14,14,29,76,208,147,52,192,243,120,46,8,22,63,215,62,197,199,255,83,215,135,251,66,165,62,100,186,92,41,233,124,189,52,163,247,2,165,194,67,119,95,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0f7879a2-86ee-4454-873c-c2e2e1511084"));
		}

		#endregion

	}

	#endregion

}

