namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ISysCultureInfoProviderSchema

	/// <exclude/>
	public class ISysCultureInfoProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ISysCultureInfoProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ISysCultureInfoProviderSchema(ISysCultureInfoProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e8d77611-044f-49a7-9b8f-472b0b015ec7");
			Name = "ISysCultureInfoProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6d2d1275-178c-4cc9-a265-eb797a3ca54a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,146,177,106,195,48,16,134,231,4,242,14,34,89,218,197,222,19,215,139,7,99,104,33,52,121,1,213,58,39,7,214,201,156,164,210,16,250,238,149,37,108,168,75,233,214,77,250,245,253,119,255,73,34,169,193,14,178,5,113,6,102,105,77,231,178,202,80,135,23,207,210,161,161,236,204,146,108,31,215,155,245,125,179,94,121,139,116,17,167,155,117,160,15,139,125,240,246,61,180,35,108,179,26,8,24,219,192,4,106,199,112,9,170,104,200,1,119,161,225,94,52,193,83,249,222,121,134,134,58,115,100,243,142,10,56,226,131,127,235,177,21,56,209,191,195,171,123,52,204,13,94,192,93,141,178,123,113,140,37,210,97,158,231,162,176,94,107,201,183,114,18,106,112,86,216,152,91,180,169,116,104,216,25,214,105,242,217,152,47,157,197,32,89,106,65,225,242,158,182,168,182,229,105,81,69,1,57,236,16,56,43,242,200,70,235,98,6,241,10,82,61,212,30,85,48,60,30,254,33,41,41,248,248,25,118,84,255,206,25,158,34,161,83,210,103,180,174,88,160,101,98,39,100,244,84,198,147,155,149,29,144,74,15,21,247,159,233,111,124,19,131,246,5,161,18,187,9,150,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e8d77611-044f-49a7-9b8f-472b0b015ec7"));
		}

		#endregion

	}

	#endregion

}

