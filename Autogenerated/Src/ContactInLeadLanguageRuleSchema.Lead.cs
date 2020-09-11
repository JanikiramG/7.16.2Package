namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ContactInLeadLanguageRuleSchema

	/// <exclude/>
	public class ContactInLeadLanguageRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ContactInLeadLanguageRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ContactInLeadLanguageRuleSchema(ContactInLeadLanguageRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("dd37686f-0318-45bd-ba58-4b312c10abb5");
			Name = "ContactInLeadLanguageRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("df5a8bee-e0f6-4225-b7c8-127f6fd1b1ca");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,146,219,138,219,64,12,134,175,179,176,239,32,220,155,4,194,248,62,71,218,176,44,129,221,182,123,188,87,60,114,50,96,207,184,115,72,49,97,223,189,26,219,201,38,46,41,189,49,88,35,125,250,245,75,26,75,114,21,102,4,175,100,45,58,147,123,177,50,58,87,219,96,209,43,163,111,111,14,183,55,131,224,148,222,194,75,237,60,149,211,211,255,121,137,165,107,113,113,167,189,242,138,28,39,112,202,23,75,91,230,194,170,64,231,38,192,205,60,102,126,173,31,8,229,3,234,109,192,45,61,135,130,154,228,52,77,97,230,66,89,162,173,23,221,127,83,56,6,191,67,15,149,53,123,37,201,65,214,98,64,105,40,24,4,69,71,2,203,40,113,36,165,103,168,42,108,10,149,65,22,105,215,85,192,4,190,161,163,75,97,131,67,35,238,115,20,163,157,183,33,243,198,242,68,63,27,112,155,209,215,223,14,96,9,61,107,86,92,133,154,173,55,57,39,17,65,102,41,159,39,87,181,36,233,66,156,160,105,159,58,171,208,98,9,154,23,58,79,130,35,203,28,77,89,220,97,178,120,227,255,232,81,23,16,179,180,201,110,138,59,35,174,182,29,190,93,192,224,146,61,138,136,193,4,54,236,210,176,247,4,135,230,49,126,62,58,199,72,203,214,180,75,7,31,201,239,140,252,31,243,126,108,60,178,113,159,11,230,245,243,125,229,138,7,204,173,41,251,151,240,47,199,148,222,145,85,94,154,12,210,115,43,204,158,15,152,185,112,31,148,132,123,242,71,59,214,114,216,132,98,71,95,63,83,102,172,92,203,227,156,123,180,64,238,23,204,65,211,111,104,174,190,126,201,118,84,226,83,32,91,247,124,20,231,9,143,168,25,111,199,144,68,247,147,209,244,4,60,206,185,50,69,40,245,119,222,46,243,185,139,248,42,101,27,27,38,79,1,139,232,128,236,118,40,142,122,197,154,89,34,22,181,192,182,101,39,191,227,240,120,109,184,167,111,220,159,178,69,88,242,193,234,238,109,25,171,95,235,138,58,41,239,88,4,154,69,139,22,195,191,133,143,96,185,108,44,21,119,101,229,235,233,245,187,104,163,151,193,143,63,47,193,218,200,171,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("dd37686f-0318-45bd-ba58-4b312c10abb5"));
		}

		#endregion

	}

	#endregion

}

