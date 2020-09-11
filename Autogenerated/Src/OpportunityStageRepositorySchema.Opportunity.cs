namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OpportunityStageRepositorySchema

	/// <exclude/>
	public class OpportunityStageRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OpportunityStageRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OpportunityStageRepositorySchema(OpportunityStageRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("55be1109-390d-43ae-b7ab-5425c01ee864");
			Name = "OpportunityStageRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5ef32b22-5119-483b-953d-678c3fffad13");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,84,75,143,155,48,16,62,103,165,253,15,35,122,97,165,21,220,243,146,42,186,93,245,208,110,219,77,123,119,204,144,80,129,205,142,237,149,162,40,255,189,131,77,18,146,194,182,82,79,200,248,155,249,30,51,160,68,141,166,17,18,97,133,68,194,232,194,38,153,86,69,185,113,36,108,169,213,237,205,254,246,102,226,76,169,54,23,16,194,217,200,251,228,65,217,210,150,104,24,192,144,119,132,27,238,3,89,37,140,153,194,83,211,104,178,78,149,118,231,113,187,103,43,54,248,65,88,225,209,105,154,194,220,184,186,22,180,91,118,231,94,9,152,22,13,57,195,65,106,101,73,72,155,28,203,210,171,186,185,65,20,149,209,32,9,139,69,52,98,48,57,9,136,32,109,75,27,183,174,74,9,178,213,219,231,62,225,96,10,153,174,107,173,122,210,39,123,47,255,16,44,163,202,131,235,191,36,224,27,124,199,70,155,210,106,218,141,38,176,218,34,208,9,6,133,38,208,131,161,252,111,22,189,145,156,101,237,199,208,67,225,28,254,37,197,115,111,206,114,144,115,62,212,123,25,114,158,156,19,213,138,189,43,203,169,126,245,124,62,193,19,119,123,203,225,80,187,163,189,126,153,144,91,124,36,237,154,47,188,253,176,128,232,154,204,68,97,119,175,39,121,73,76,78,178,212,97,238,113,199,241,15,131,196,245,10,101,27,34,184,139,227,93,219,99,50,133,181,48,24,95,94,221,255,169,51,186,31,247,117,7,62,170,195,219,70,62,163,221,234,188,245,64,218,50,15,230,157,141,227,17,244,43,79,191,204,113,248,83,200,8,133,197,167,245,47,6,127,36,93,135,97,198,225,17,22,179,19,50,25,172,247,95,242,194,219,77,70,122,133,38,51,223,195,239,248,39,243,236,164,68,99,10,87,113,173,191,79,30,209,174,118,13,230,153,174,92,173,126,138,202,225,124,173,117,181,140,163,51,58,234,218,16,90,71,202,147,207,122,33,13,152,238,150,147,131,173,197,55,135,188,176,76,20,94,50,83,21,38,243,96,94,226,163,203,87,65,128,230,229,232,105,12,29,116,48,48,121,159,119,154,223,16,202,184,217,200,48,7,126,57,135,223,183,161,55,44,213,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("55be1109-390d-43ae-b7ab-5425c01ee864"));
		}

		#endregion

	}

	#endregion

}

