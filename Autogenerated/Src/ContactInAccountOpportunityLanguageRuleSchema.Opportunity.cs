namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ContactInAccountOpportunityLanguageRuleSchema

	/// <exclude/>
	public class ContactInAccountOpportunityLanguageRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ContactInAccountOpportunityLanguageRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ContactInAccountOpportunityLanguageRuleSchema(ContactInAccountOpportunityLanguageRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0a831195-1dd5-446c-9d0a-2a61dd77a5bb");
			Name = "ContactInAccountOpportunityLanguageRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0e987dc8-e3a7-4136-b3d3-af8a5676bbce");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,83,75,107,227,48,16,62,167,208,255,48,120,47,9,4,249,158,39,109,40,37,176,221,118,251,186,43,242,56,17,216,146,59,146,178,152,208,255,190,227,71,82,199,75,151,92,2,30,205,124,175,153,24,153,163,43,164,66,120,69,34,233,108,234,197,202,154,84,111,3,73,175,173,185,190,58,92,95,13,130,211,102,11,47,165,243,152,79,79,223,221,17,194,239,234,226,206,120,237,53,58,110,224,150,31,132,91,198,133,85,38,157,155,0,147,121,169,252,218,220,40,101,131,241,143,69,97,201,7,163,125,249,83,154,109,144,91,124,14,25,214,163,113,28,195,204,133,60,151,84,46,218,239,26,102,12,126,39,61,20,100,247,58,65,7,170,1,133,172,69,128,212,18,116,144,197,17,44,238,160,21,97,147,105,5,170,2,188,84,22,76,224,86,58,60,87,58,56,212,106,191,156,90,227,60,5,229,45,177,225,167,154,166,233,232,27,106,28,17,74,207,38,52,79,73,195,155,177,41,55,33,130,34,76,231,209,133,202,162,120,33,78,20,113,159,99,86,72,146,57,24,222,254,60,10,14,137,81,13,170,106,225,209,226,141,191,171,8,219,130,152,197,117,119,61,220,134,116,161,136,225,219,25,52,156,51,141,42,192,193,4,54,156,224,176,247,4,135,250,177,250,249,108,211,68,147,52,129,158,167,251,128,126,103,147,75,130,125,220,120,201,161,126,93,5,223,10,159,102,170,217,110,74,54,63,157,141,54,32,27,95,255,139,80,155,29,146,246,137,85,16,119,179,177,123,62,127,134,134,251,160,19,184,71,127,76,100,157,12,235,82,69,234,203,103,84,150,146,117,114,180,186,151,4,232,62,96,14,6,255,64,253,159,41,95,212,14,115,249,59,32,149,189,40,69,183,225,65,26,134,167,49,68,157,61,68,163,233,9,247,232,120,101,179,144,155,95,188,117,166,97,50,113,147,36,77,109,24,181,155,20,79,164,43,159,237,134,197,81,188,88,39,209,72,84,163,13,108,195,223,122,105,209,216,107,83,238,137,29,247,45,55,16,132,62,144,105,223,150,213,244,107,89,96,43,232,93,102,1,103,85,94,139,225,191,242,71,176,92,214,249,138,187,188,240,229,244,251,59,105,170,231,197,207,191,209,175,91,139,246,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0a831195-1dd5-446c-9d0a-2a61dd77a5bb"));
		}

		#endregion

	}

	#endregion

}

