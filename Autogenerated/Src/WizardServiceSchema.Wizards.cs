namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WizardServiceSchema

	/// <exclude/>
	public class WizardServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WizardServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WizardServiceSchema(WizardServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("467d8f7f-4fb4-4876-adaa-b5904a205d6f");
			Name = "WizardService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("35c77563-f7ec-4c0b-91e3-f2665bae1236");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,82,77,107,27,49,16,61,175,193,255,97,72,46,54,24,249,158,182,129,196,16,218,130,155,144,77,240,193,244,32,107,199,182,200,74,218,106,180,14,219,210,255,222,145,180,113,214,20,156,147,208,155,55,31,239,205,88,105,144,26,169,16,158,208,123,73,110,27,196,194,217,173,222,181,94,6,237,236,120,244,103,60,42,90,210,118,7,101,71,1,141,40,209,31,180,194,165,171,176,254,116,46,40,110,84,208,135,84,230,60,111,133,155,119,194,251,32,12,243,48,198,164,116,142,95,122,220,113,45,88,212,146,232,10,86,250,183,244,85,95,40,17,230,243,57,124,166,214,24,233,187,235,254,255,28,116,173,67,7,148,121,160,98,50,108,157,135,87,231,95,98,195,87,29,246,125,49,241,86,100,62,168,178,238,91,176,47,193,75,21,126,70,236,134,154,31,24,120,186,134,245,109,82,139,71,252,213,106,143,6,109,160,201,240,19,69,194,23,248,32,37,178,68,15,84,211,216,164,105,55,181,86,253,196,39,106,225,10,110,37,225,81,123,17,151,116,244,103,137,97,239,42,118,232,33,21,72,214,252,231,77,2,22,53,74,15,106,184,112,32,229,117,19,96,235,157,1,37,105,47,142,217,67,83,138,245,125,131,57,99,232,75,177,230,165,125,179,7,247,130,147,60,6,11,191,120,184,47,159,46,102,112,235,170,174,12,93,29,205,96,218,18,137,228,14,143,168,88,121,217,52,88,205,98,157,34,58,129,20,238,156,55,50,156,36,100,72,124,39,103,103,240,200,231,235,44,225,121,94,178,243,205,207,131,211,85,86,126,114,233,101,210,61,153,66,242,178,56,141,161,138,207,87,172,89,180,200,185,82,237,113,242,204,103,197,76,155,227,211,120,197,197,223,108,248,37,218,42,47,132,127,25,27,66,227,17,99,255,0,210,139,193,90,127,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("467d8f7f-4fb4-4876-adaa-b5904a205d6f"));
		}

		#endregion

	}

	#endregion

}

