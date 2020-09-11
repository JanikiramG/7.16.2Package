namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SetWinnerOpportunityEventListenerSchema

	/// <exclude/>
	public class SetWinnerOpportunityEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SetWinnerOpportunityEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SetWinnerOpportunityEventListenerSchema(SetWinnerOpportunityEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("231522b7-74cb-4b33-902e-c806990f6c39");
			Name = "SetWinnerOpportunityEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5ef32b22-5119-483b-953d-678c3fffad13");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,83,193,110,219,48,12,61,187,64,255,129,240,46,54,80,200,247,54,41,176,118,233,118,216,150,1,105,209,195,208,131,98,51,137,10,91,50,40,217,67,80,244,223,75,73,118,144,172,105,115,146,69,241,145,143,239,209,90,54,104,91,89,34,220,35,145,180,102,229,196,173,209,43,181,238,72,58,101,244,249,217,203,249,89,210,89,165,215,7,41,132,98,166,157,114,10,237,213,169,4,49,235,81,59,159,199,153,95,8,215,92,23,110,107,105,237,37,44,208,61,42,173,145,230,109,107,200,117,90,185,109,72,255,169,172,67,142,7,80,81,20,48,177,93,211,72,218,94,15,247,31,82,87,53,18,172,12,193,30,24,208,119,229,35,244,20,35,184,248,15,61,177,136,178,182,6,74,194,213,52,253,156,185,184,145,22,67,236,144,91,10,133,175,247,247,200,83,182,40,55,216,200,223,172,47,76,33,221,35,152,230,79,140,105,187,101,173,74,40,189,10,167,69,128,75,248,128,2,151,122,9,18,237,132,253,133,110,99,42,150,246,15,25,135,165,195,42,190,183,227,21,122,197,61,100,13,189,81,149,239,189,215,53,210,200,102,131,134,225,200,193,175,64,146,244,146,192,30,201,158,183,24,119,133,7,13,234,221,201,210,25,242,242,5,147,227,117,43,190,163,155,28,235,182,195,95,103,161,79,146,104,252,247,174,146,209,214,81,231,175,95,105,221,53,76,45,75,59,139,196,15,154,199,98,120,122,49,16,22,15,7,241,60,191,10,117,63,229,46,190,153,221,119,54,204,29,96,175,131,186,168,171,40,240,71,106,7,67,227,99,88,48,165,55,72,202,85,166,140,91,50,90,110,122,222,53,85,97,148,127,174,23,178,231,127,39,51,203,103,166,203,2,235,10,233,2,162,3,55,200,219,141,193,112,158,218,2,142,94,44,121,27,196,14,59,130,112,152,212,59,53,252,6,83,24,204,204,99,82,76,56,106,250,233,169,99,244,48,248,250,6,206,77,237,177,67,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("231522b7-74cb-4b33-902e-c806990f6c39"));
		}

		#endregion

	}

	#endregion

}

