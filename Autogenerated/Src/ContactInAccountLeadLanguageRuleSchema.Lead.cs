namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ContactInAccountLeadLanguageRuleSchema

	/// <exclude/>
	public class ContactInAccountLeadLanguageRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ContactInAccountLeadLanguageRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ContactInAccountLeadLanguageRuleSchema(ContactInAccountLeadLanguageRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cfdf212a-4f1d-4503-a3e8-25f804f8d198");
			Name = "ContactInAccountLeadLanguageRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("df5a8bee-e0f6-4225-b7c8-127f6fd1b1ca");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,147,219,110,219,48,12,134,175,83,160,239,64,120,55,9,16,216,247,57,162,11,138,34,64,187,245,124,175,72,116,34,192,150,60,29,50,24,65,223,125,148,108,167,137,135,46,187,9,96,138,252,200,255,39,163,88,137,182,98,28,225,21,141,97,86,231,46,93,105,149,203,173,55,204,73,173,174,175,14,215,87,3,111,165,218,194,75,109,29,150,211,227,247,105,137,193,175,226,233,173,114,210,73,180,148,64,41,223,12,110,137,11,171,130,89,59,1,106,230,24,119,107,117,195,185,246,202,221,35,19,247,76,109,61,219,226,179,47,48,214,100,89,6,51,235,203,146,153,122,209,126,199,250,49,184,29,115,80,25,189,151,2,45,240,134,6,185,209,37,176,134,8,82,65,65,84,40,90,44,24,226,166,29,54,59,225,86,126,83,72,14,60,160,47,78,6,19,248,206,44,158,15,59,56,196,129,63,85,106,101,157,241,220,105,67,98,31,35,191,201,232,107,106,68,25,100,142,116,72,170,98,138,182,162,115,74,66,4,110,48,159,39,151,70,74,178,69,122,100,103,125,248,172,98,134,149,160,104,229,243,196,91,52,132,83,200,195,150,147,197,27,125,7,251,218,64,58,203,98,118,44,110,109,185,212,125,248,118,198,132,243,22,163,64,26,76,96,67,158,13,123,79,112,136,143,225,231,163,245,15,149,104,44,60,247,243,1,221,78,139,255,177,242,231,198,49,178,241,115,235,116,32,116,136,185,36,157,241,60,186,91,161,243,232,46,37,198,195,173,252,203,69,169,118,104,164,19,154,67,118,106,143,222,211,217,83,19,184,243,82,192,29,186,206,155,181,24,198,80,104,239,234,103,228,218,136,181,232,68,239,153,1,180,191,96,14,10,127,67,252,175,212,47,124,135,37,123,242,104,234,158,169,233,105,194,3,83,132,55,99,72,194,42,146,209,244,8,236,68,175,116,225,75,245,131,54,78,124,234,146,222,8,209,196,134,201,147,103,69,176,67,180,235,76,31,141,12,74,219,53,167,221,248,233,154,208,105,96,52,252,102,130,86,77,139,37,181,77,184,55,238,184,47,186,65,24,116,222,168,246,109,25,170,95,235,10,219,201,222,89,225,113,22,28,91,12,255,214,49,130,229,50,58,156,222,150,149,171,167,95,223,76,19,61,15,126,252,1,215,29,113,207,240,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cfdf212a-4f1d-4503-a3e8-25f804f8d198"));
		}

		#endregion

	}

	#endregion

}

