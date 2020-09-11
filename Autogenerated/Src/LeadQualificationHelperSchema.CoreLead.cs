namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LeadQualificationHelperSchema

	/// <exclude/>
	public class LeadQualificationHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LeadQualificationHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LeadQualificationHelperSchema(LeadQualificationHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b0f5b581-b090-487e-b10f-878e77de698a");
			Name = "LeadQualificationHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("574c9bf8-30b5-4eb9-aa34-ee8fc5cac038");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,84,203,78,195,48,16,60,23,137,127,176,210,11,149,160,185,211,135,84,33,1,149,138,196,171,31,96,146,77,177,228,56,209,218,169,84,33,254,157,141,243,32,118,27,40,112,32,167,120,237,157,157,157,241,90,241,20,116,206,35,96,207,128,200,117,150,152,241,85,166,18,177,41,144,27,145,41,246,118,122,50,40,180,80,27,246,180,211,6,210,73,187,238,102,32,80,156,118,134,8,155,50,107,169,12,96,66,184,151,108,185,2,30,63,20,92,138,68,68,22,243,22,100,14,104,207,135,97,200,166,186,72,83,142,187,121,189,30,54,31,123,181,7,47,134,101,168,13,127,238,183,139,113,131,20,118,160,242,226,69,138,136,137,134,73,47,145,178,69,58,191,199,197,33,195,246,138,58,60,170,213,184,133,9,125,156,105,206,145,167,76,145,222,179,64,18,145,101,28,204,125,72,23,108,26,218,28,11,177,205,68,204,22,81,73,122,145,80,67,203,24,148,105,251,56,187,41,104,187,66,29,149,6,189,87,102,128,138,43,63,28,111,34,201,181,190,100,191,178,165,182,228,47,134,216,242,125,213,251,175,75,227,82,211,197,181,144,16,83,27,247,152,25,136,12,196,71,152,232,201,236,71,122,236,203,155,10,12,137,90,166,228,142,173,53,32,141,137,2,235,136,183,156,124,193,100,253,184,98,191,41,168,13,150,35,183,200,115,89,171,178,70,89,23,242,108,110,21,34,70,148,86,68,38,195,82,39,171,254,49,34,29,188,227,245,31,165,1,176,8,33,153,5,61,70,5,225,252,216,57,40,28,221,58,243,240,141,79,221,201,216,3,229,142,70,193,220,147,188,155,91,223,200,158,70,206,60,151,93,182,231,141,39,110,189,145,125,48,7,3,47,119,230,101,79,236,33,215,78,58,196,125,127,7,245,40,247,154,124,7,230,53,139,127,226,239,63,191,100,181,230,91,129,134,36,103,63,120,216,42,101,15,235,113,232,193,163,216,7,147,68,247,57,223,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b0f5b581-b090-487e-b10f-878e77de698a"));
		}

		#endregion

	}

	#endregion

}

