namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ValidateSenderRequestSchema

	/// <exclude/>
	public class ValidateSenderRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ValidateSenderRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ValidateSenderRequestSchema(ValidateSenderRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("efc01930-33c9-4ec2-8ddf-662cdd8b0a08");
			Name = "ValidateSenderRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,82,193,78,194,64,16,61,75,194,63,76,234,65,189,180,119,40,28,68,66,76,196,16,74,188,24,15,203,50,173,155,236,182,56,179,37,65,226,191,59,221,22,140,168,241,180,153,55,239,189,204,123,217,82,57,228,173,210,8,43,36,82,92,229,62,158,84,101,110,138,154,148,55,85,25,79,166,217,188,218,160,229,126,239,208,239,93,212,108,202,2,178,61,123,116,194,180,22,117,67,227,120,134,37,146,209,195,115,206,178,46,189,113,24,103,178,85,214,188,7,87,97,9,239,146,176,144,1,38,86,49,15,224,73,214,27,229,49,195,114,131,180,196,183,26,217,7,98,146,36,144,114,237,156,162,253,184,155,131,8,242,138,128,90,38,248,10,118,157,5,112,240,184,98,64,167,140,229,248,104,146,156,185,164,140,168,44,87,160,9,243,81,244,111,9,241,173,98,57,144,118,70,99,119,97,4,73,227,246,124,167,188,18,149,39,165,253,139,0,219,122,109,141,6,29,238,252,53,27,12,224,167,157,40,15,33,244,169,158,5,85,91,36,111,80,58,90,4,211,118,127,222,74,0,102,232,25,164,20,110,94,255,138,109,1,96,13,251,248,36,74,206,85,169,20,87,227,105,92,253,165,251,162,133,184,115,116,107,164,235,71,249,68,48,130,40,72,30,68,17,221,52,5,28,27,184,159,150,181,67,82,107,139,41,123,146,191,49,134,233,145,10,7,40,208,15,155,123,135,240,209,5,151,146,218,236,97,110,209,239,160,96,159,189,24,179,161,187,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("efc01930-33c9-4ec2-8ddf-662cdd8b0a08"));
		}

		#endregion

	}

	#endregion

}

