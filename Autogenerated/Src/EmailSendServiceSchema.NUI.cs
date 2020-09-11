﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailSendServiceSchema

	/// <exclude/>
	public class EmailSendServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailSendServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailSendServiceSchema(EmailSendServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ae3b2d03-d334-4f08-892a-e59dcebd13c3");
			Name = "EmailSendService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("cd322293-860d-4ac9-8e55-034f9e973ce3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,85,77,111,219,48,12,61,103,192,254,131,144,147,2,4,198,206,107,87,32,203,210,173,195,210,47,103,235,161,216,65,181,217,68,152,252,49,73,110,107,20,253,239,35,37,57,177,29,55,219,14,78,108,241,61,146,122,164,168,92,100,96,74,145,0,91,129,214,194,20,247,54,154,23,249,189,92,87,90,88,89,228,209,34,19,82,197,144,167,49,232,7,153,192,219,55,207,111,223,140,42,35,243,53,139,107,99,33,59,234,125,163,3,165,32,33,182,137,62,67,14,90,38,123,152,224,109,89,164,160,14,26,163,25,122,122,112,185,28,198,221,192,221,14,208,222,77,150,181,169,109,139,134,104,145,91,105,37,152,87,1,167,34,177,133,126,5,177,68,109,34,18,7,244,144,25,83,218,197,71,251,109,72,24,21,182,26,253,254,164,181,153,41,207,193,34,172,196,77,222,73,37,109,125,13,191,43,169,33,131,220,26,222,254,160,157,178,15,236,47,20,66,69,97,33,157,80,144,178,186,83,50,97,137,18,198,176,126,69,217,123,246,81,24,216,214,119,244,236,146,29,221,94,148,224,155,160,157,239,232,22,119,117,150,63,20,191,128,47,193,110,138,20,19,26,95,94,196,171,241,148,125,215,114,5,89,169,132,165,52,199,20,4,87,63,22,105,29,219,90,209,26,146,151,96,140,88,195,118,53,186,209,162,44,33,157,146,247,17,229,13,198,158,22,58,19,182,67,240,75,209,87,83,228,83,118,141,109,139,253,5,135,113,110,243,205,238,191,73,99,143,41,37,228,86,202,158,48,122,231,198,106,42,154,235,50,212,241,44,157,176,103,151,72,48,16,200,43,102,133,173,12,109,235,44,191,212,197,90,99,180,241,145,131,222,21,133,98,27,97,78,177,241,139,71,100,161,61,65,243,66,185,130,32,231,94,40,3,30,108,117,29,34,140,30,132,102,64,190,231,74,34,206,183,90,141,240,57,21,42,124,226,17,178,199,139,61,212,9,207,225,145,97,101,48,207,138,86,102,122,93,81,52,62,174,12,104,52,228,254,12,82,89,58,11,147,201,209,46,188,8,251,222,54,5,104,140,79,174,103,251,22,190,159,236,158,243,224,187,97,111,3,160,215,129,88,238,240,240,207,149,76,163,75,161,13,240,86,29,26,87,7,133,229,164,253,164,241,28,5,59,105,134,175,216,191,182,254,33,84,5,124,124,14,79,182,203,190,6,145,214,227,38,202,64,157,93,138,105,168,241,11,75,132,77,54,140,59,208,226,41,129,146,246,203,160,233,151,1,15,208,154,158,110,45,184,114,191,164,190,217,90,22,241,85,208,221,77,164,58,78,54,40,246,85,5,186,230,93,133,163,54,96,41,114,236,120,61,101,227,94,164,102,95,157,8,40,143,204,132,174,157,91,156,210,85,150,71,103,102,166,30,69,109,98,160,153,141,57,96,59,193,16,119,150,166,158,130,90,226,173,49,28,160,5,154,227,20,26,6,157,74,101,65,27,2,243,174,101,174,1,71,135,183,223,72,187,193,158,192,80,4,230,94,227,145,183,185,209,167,37,158,240,85,93,162,202,191,43,161,166,44,64,124,228,237,103,175,44,126,181,105,174,94,17,156,178,187,235,11,213,232,230,135,109,213,199,240,193,254,111,252,250,81,67,147,39,84,183,63,132,120,32,200,123,198,95,79,4,111,145,10,219,253,132,189,155,180,103,135,196,75,176,155,99,143,119,251,238,103,104,239,110,50,78,122,74,103,151,9,223,122,30,125,146,6,71,184,63,56,232,158,162,52,157,19,76,190,198,14,48,13,164,33,116,11,22,173,138,216,13,84,62,105,24,115,127,153,57,2,10,75,149,76,91,140,99,63,128,79,154,78,106,104,95,14,141,131,215,103,133,103,191,76,154,211,236,254,52,216,74,231,189,74,57,132,59,163,248,188,244,111,207,157,98,254,166,220,94,47,225,190,232,136,231,21,93,131,109,142,65,203,121,151,246,191,120,39,222,63,192,221,213,116,64,178,3,46,240,121,249,3,93,130,213,208,32,10,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ae3b2d03-d334-4f08-892a-e59dcebd13c3"));
		}

		#endregion

	}

	#endregion

}
