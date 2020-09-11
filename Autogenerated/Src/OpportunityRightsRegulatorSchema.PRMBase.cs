namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OpportunityRightsRegulatorSchema

	/// <exclude/>
	public class OpportunityRightsRegulatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OpportunityRightsRegulatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OpportunityRightsRegulatorSchema(OpportunityRightsRegulatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1f85e969-5663-4fc5-857b-99942ce033c3");
			Name = "OpportunityRightsRegulator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6efc2b6b-5901-4b9d-a21e-e587e5c1977b");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,84,193,110,219,48,12,61,187,64,255,129,232,46,9,80,56,247,166,43,80,4,89,145,67,151,162,233,118,29,52,155,145,5,88,146,65,73,201,188,162,255,62,69,74,92,219,141,129,108,193,142,36,197,247,248,158,73,43,38,209,84,44,67,120,65,34,102,244,218,166,51,173,214,130,59,98,86,104,117,121,241,122,121,145,56,35,20,135,85,109,44,202,105,19,183,91,164,212,234,120,133,112,40,159,206,149,21,86,160,73,239,77,173,178,101,133,145,211,252,117,67,186,80,22,105,237,117,236,122,125,247,39,66,238,11,48,43,153,49,55,176,172,42,77,214,41,97,235,103,193,11,107,158,145,187,146,89,77,225,245,100,50,129,91,227,164,100,84,223,237,227,208,9,219,66,100,5,224,47,204,156,69,3,250,192,8,107,77,144,21,76,241,221,148,20,48,193,167,245,59,81,10,7,228,73,11,186,114,63,75,145,65,22,208,63,140,21,100,53,179,193,13,44,130,226,122,190,65,101,187,154,61,214,107,24,190,209,250,69,96,153,123,177,79,36,54,204,98,44,86,49,128,149,169,34,84,79,63,252,160,110,98,186,7,69,149,71,220,46,201,35,218,66,15,178,108,180,200,225,145,41,198,177,165,109,73,156,41,241,59,140,29,233,71,131,178,238,137,27,96,196,157,244,37,51,134,221,246,37,73,127,200,52,114,68,148,35,240,13,64,220,152,122,145,95,7,156,164,95,152,233,210,73,245,157,149,206,47,213,3,218,151,186,194,60,132,183,15,78,228,119,163,171,39,70,86,33,45,242,171,241,7,140,101,153,255,3,204,120,183,222,201,219,73,206,109,125,207,255,176,172,133,123,220,152,51,28,11,224,231,250,213,128,140,167,112,240,235,148,173,12,231,181,183,54,158,90,112,118,30,47,120,244,205,32,249,255,155,194,44,92,177,235,132,215,112,166,199,240,25,20,110,7,111,109,212,167,235,123,187,202,10,148,236,171,255,39,199,29,73,78,57,165,247,169,134,122,90,31,187,247,248,237,232,177,199,108,55,233,115,127,0,33,147,155,33,44,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1f85e969-5663-4fc5-857b-99942ce033c3"));
		}

		#endregion

	}

	#endregion

}

