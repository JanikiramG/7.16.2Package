namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ContractEntityEventListenerSchema

	/// <exclude/>
	public class ContractEntityEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ContractEntityEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ContractEntityEventListenerSchema(ContractEntityEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8dc1c550-b00c-4bed-b991-26641e373489");
			Name = "ContractEntityEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d07c15be-3f83-4fdc-a9ea-aad9ed069b01");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,83,193,110,219,48,12,61,167,64,255,129,112,47,14,16,216,247,54,45,176,6,65,81,96,107,11,180,219,165,216,65,177,153,196,155,45,121,164,236,33,40,250,239,163,37,57,141,131,58,59,74,122,124,124,124,124,210,170,66,174,85,134,240,130,68,138,205,218,38,11,163,215,197,166,33,101,11,163,207,207,222,206,207,38,13,23,122,51,128,16,38,75,109,11,91,32,95,253,15,144,44,91,212,118,28,247,68,38,67,230,97,99,65,11,254,130,112,35,7,88,148,138,249,18,4,97,73,101,214,49,239,28,237,215,130,45,106,36,7,79,211,20,230,220,84,149,162,221,77,56,187,82,168,201,180,69,142,12,89,160,0,12,234,0,157,58,216,42,157,151,162,46,233,121,210,35,162,57,35,170,146,13,100,132,235,235,232,244,176,201,173,98,252,68,102,4,105,199,247,250,201,83,252,156,109,177,82,15,178,18,184,134,168,159,53,154,254,148,130,186,89,149,69,6,153,27,230,132,13,112,9,35,157,225,205,89,180,183,244,27,218,173,201,197,212,39,42,90,101,209,191,214,254,0,102,245,11,197,164,187,174,82,206,207,248,167,65,205,248,208,84,43,81,234,233,189,133,187,105,199,60,153,76,90,69,176,65,234,240,134,100,2,141,127,71,234,191,51,210,139,226,223,177,39,72,186,179,204,164,165,163,40,155,94,57,58,66,219,144,254,96,76,70,180,4,14,111,222,12,78,80,190,15,71,92,25,83,194,61,123,154,101,85,219,221,248,92,132,220,148,86,134,10,244,119,104,95,118,53,230,11,83,54,149,254,161,202,6,231,108,73,226,115,19,71,158,49,26,206,225,95,147,174,95,89,62,134,126,158,118,160,238,2,117,238,55,52,182,46,151,4,255,120,156,247,125,78,67,70,71,162,144,60,234,123,49,144,172,40,138,210,143,194,195,196,247,137,51,173,228,92,126,14,180,166,200,225,160,48,14,17,97,17,140,52,3,223,231,22,215,242,27,92,183,47,180,145,207,213,187,184,18,41,135,125,227,190,14,131,79,157,205,222,93,177,57,108,98,234,65,30,80,172,33,30,174,43,236,169,111,225,40,120,144,14,161,58,25,155,208,123,210,135,8,237,193,70,247,155,156,29,177,134,170,247,241,181,249,219,225,165,220,253,3,55,156,54,193,111,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8dc1c550-b00c-4bed-b991-26641e373489"));
		}

		#endregion

	}

	#endregion

}

