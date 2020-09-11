﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OpportunityAnniversaryRemindingSchema

	/// <exclude/>
	public class OpportunityAnniversaryRemindingSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OpportunityAnniversaryRemindingSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OpportunityAnniversaryRemindingSchema(OpportunityAnniversaryRemindingSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("02869893-cf9d-42c9-bfde-d916da7a4aa1");
			Name = "OpportunityAnniversaryReminding";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7094e60e-83c9-4747-8d9c-40b7b1b1c58b");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,87,75,111,227,54,16,62,107,129,253,15,132,122,145,81,67,238,169,135,196,49,144,196,155,173,219,205,198,27,167,237,177,96,196,177,205,174,76,106,73,202,129,177,232,127,239,240,33,153,114,228,60,122,104,14,113,196,209,188,231,155,225,72,208,13,232,138,22,64,238,64,41,170,229,210,228,151,82,44,249,170,86,212,112,41,222,191,251,254,254,93,82,107,46,86,100,177,211,6,54,167,7,103,228,47,75,40,44,179,206,63,130,0,197,139,61,79,172,86,193,49,122,62,189,192,87,248,242,7,5,43,84,68,46,75,170,245,9,185,169,42,169,76,45,184,217,157,11,193,183,160,52,85,187,91,216,112,193,80,139,19,169,234,251,146,23,164,176,18,207,9,144,19,114,65,53,244,235,74,190,59,125,123,31,48,32,67,133,209,158,92,41,190,165,6,72,97,201,132,11,67,166,176,164,117,105,206,11,83,211,114,142,113,75,70,206,200,207,167,65,13,8,230,53,117,213,94,113,40,25,198,54,119,126,7,221,62,6,52,103,240,159,2,202,164,40,119,120,86,214,233,243,162,144,181,48,55,149,205,49,90,72,3,33,61,125,94,22,131,48,180,136,100,3,225,37,178,115,170,144,204,43,26,219,142,136,233,51,145,186,4,170,186,48,82,117,195,29,141,70,100,172,235,205,6,11,48,105,8,17,119,222,50,85,84,209,13,17,136,210,179,180,214,160,144,73,120,172,165,147,223,59,103,172,136,173,86,1,249,120,228,164,90,197,227,81,108,42,132,252,12,80,178,3,229,93,219,131,19,114,143,48,202,14,168,196,182,74,146,44,138,53,108,232,103,244,217,230,43,50,228,115,158,44,100,173,10,152,89,172,180,246,92,240,58,143,152,253,171,134,215,75,254,69,187,80,115,173,211,105,215,28,123,114,1,198,160,74,219,140,230,15,90,214,48,70,176,78,14,34,26,58,133,73,250,89,26,120,64,155,235,157,215,122,37,85,228,68,84,108,157,14,251,0,63,112,158,253,99,127,222,160,178,177,18,206,210,201,101,173,20,96,103,42,40,164,98,100,198,254,7,48,12,201,199,154,51,194,25,162,194,172,185,62,130,138,91,231,146,171,58,103,77,210,14,187,199,39,177,233,159,185,146,21,96,1,192,78,11,133,133,42,12,176,134,169,25,71,118,16,117,112,225,27,187,97,119,239,59,19,202,187,179,2,19,158,18,190,36,217,1,178,206,200,79,141,223,143,81,215,131,2,15,79,15,131,36,81,96,106,37,122,188,10,12,122,111,251,80,247,214,226,53,226,109,129,117,108,198,92,131,89,75,214,77,208,81,32,222,58,199,52,209,96,47,44,242,192,205,154,208,178,36,75,94,26,172,57,89,74,69,138,0,33,252,67,56,244,227,213,203,167,147,133,215,99,197,86,190,233,8,221,227,7,81,24,0,244,52,112,191,213,160,118,161,214,187,116,242,197,30,73,21,206,29,159,188,221,87,104,203,127,3,212,24,97,58,132,69,180,155,81,78,228,21,218,220,52,73,39,119,107,216,251,199,0,83,135,113,130,38,102,87,1,145,75,236,2,64,50,194,221,143,164,71,6,60,62,244,228,90,50,190,228,136,209,87,212,99,60,106,164,143,116,116,11,124,137,33,43,206,128,132,42,77,189,71,224,143,89,160,122,211,67,130,137,114,209,205,41,87,99,127,255,13,195,61,56,33,157,44,52,141,225,37,61,140,243,115,193,178,65,120,190,169,64,92,148,178,248,218,80,98,210,254,114,24,146,116,97,232,10,135,123,58,200,103,26,7,241,135,111,216,10,25,174,83,245,70,4,201,36,159,219,220,217,28,103,209,148,106,87,147,248,198,184,44,165,6,118,11,127,187,248,103,108,48,104,149,88,247,94,107,249,191,152,86,178,126,27,211,127,74,241,6,86,63,73,109,34,179,185,163,30,150,94,245,193,160,177,121,85,139,34,159,34,42,167,124,185,108,169,73,67,113,179,192,242,216,70,154,9,244,12,7,100,126,141,43,220,122,216,50,251,40,114,191,42,248,67,55,246,105,13,86,97,58,216,203,56,187,225,182,180,239,238,248,6,90,63,147,230,193,38,235,19,104,125,163,226,124,69,105,234,108,2,79,164,161,67,242,227,93,99,183,23,107,146,245,76,152,246,234,41,112,201,234,110,156,39,193,70,152,132,191,74,46,50,251,115,135,163,39,159,225,157,171,134,36,218,191,126,220,239,187,123,108,220,28,164,39,160,194,135,216,47,124,168,212,138,156,190,192,149,126,235,145,218,151,25,111,30,99,179,247,184,173,127,13,7,230,111,228,110,114,240,54,237,91,102,244,47,80,98,174,157,191,119,244,190,132,172,25,129,113,82,30,221,34,125,118,253,109,30,110,123,175,37,94,108,122,70,241,86,226,166,52,195,6,250,18,233,199,253,38,107,74,110,215,234,188,151,193,155,60,103,44,126,179,203,218,111,161,102,90,231,31,54,149,217,29,101,127,156,212,244,37,188,49,6,7,207,4,57,229,174,93,49,233,237,69,242,212,237,50,33,184,167,59,203,254,35,75,239,229,219,180,108,169,34,114,255,22,75,235,18,245,132,160,143,41,146,201,49,190,172,243,37,57,36,2,30,158,116,237,104,118,143,168,239,124,108,190,68,125,95,53,142,232,126,244,49,250,74,253,157,10,6,27,1,186,145,169,99,139,57,158,61,53,38,34,229,95,75,220,252,116,64,17,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("02869893-cf9d-42c9-bfde-d916da7a4aa1"));
		}

		#endregion

	}

	#endregion

}
