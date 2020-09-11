namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FastReportAppEventListenerSchema

	/// <exclude/>
	public class FastReportAppEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FastReportAppEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FastReportAppEventListenerSchema(FastReportAppEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1c2eae70-2e46-4408-b770-04ce11ee4b96");
			Name = "FastReportAppEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6b2e55c4-93df-4e50-a678-d373851bda85");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,80,193,78,195,48,12,61,119,210,254,33,18,151,113,201,7,108,39,24,67,66,2,129,24,18,103,55,245,58,75,173,83,37,110,133,152,248,119,220,100,163,3,77,156,18,191,247,252,252,108,134,22,99,7,14,205,27,134,0,209,239,196,174,61,239,168,238,3,8,121,182,175,216,249,32,196,181,189,135,40,185,218,112,77,140,243,217,97,62,43,250,168,220,89,247,37,253,104,201,232,70,191,213,133,150,119,44,85,209,182,137,85,254,42,96,173,82,179,110,32,198,165,153,124,110,186,110,51,32,203,35,69,65,198,144,212,93,95,54,228,140,27,197,255,104,205,210,252,133,110,33,234,18,197,33,217,252,76,125,66,217,251,74,231,190,36,227,76,30,135,248,65,67,83,133,102,240,84,153,103,86,199,173,64,144,197,201,90,23,21,252,16,227,242,123,109,198,19,21,69,169,147,236,153,252,68,175,18,155,3,223,129,192,214,247,193,225,116,173,7,38,33,104,232,19,131,157,254,139,220,247,117,204,141,92,229,232,169,206,232,111,80,177,111,203,30,74,252,233,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1c2eae70-2e46-4408-b770-04ce11ee4b96"));
		}

		#endregion

	}

	#endregion

}

