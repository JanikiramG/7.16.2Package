﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailClientFactorySchema

	/// <exclude/>
	public class EmailClientFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailClientFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailClientFactorySchema(EmailClientFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bb18ef6c-25c9-43e3-b6da-de0755b0e432");
			Name = "EmailClientFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,88,75,111,27,55,16,62,43,64,254,3,161,94,86,128,42,1,61,198,182,2,215,137,91,29,220,24,177,211,75,144,3,189,203,149,88,172,72,129,228,202,48,2,255,247,14,31,43,241,177,43,173,85,185,1,138,30,53,250,230,193,153,143,51,179,100,120,69,228,26,231,4,221,19,33,176,228,165,154,220,96,90,77,238,8,43,136,64,111,223,124,127,251,102,80,75,202,22,30,226,138,179,146,46,106,129,21,229,236,172,21,32,72,151,124,114,141,115,197,5,37,114,135,248,112,255,9,93,160,143,43,240,12,182,149,0,196,4,100,0,0,200,79,130,44,192,15,186,170,176,148,239,28,170,162,132,41,107,233,201,160,166,211,41,58,151,245,106,133,197,211,204,253,54,80,148,27,44,42,45,24,209,213,186,34,43,144,152,232,39,141,234,212,211,253,250,129,148,184,174,212,175,148,21,16,94,166,158,214,132,151,217,60,117,61,26,125,3,252,186,126,168,104,14,142,32,192,150,248,208,59,212,162,138,190,155,184,183,199,187,166,21,41,224,124,183,130,110,176,34,246,207,181,224,138,228,138,20,72,16,92,112,86,61,161,47,146,8,72,18,3,177,86,11,127,158,57,155,80,61,107,54,244,1,64,169,68,173,253,107,79,38,108,139,8,210,55,209,128,73,144,18,11,88,99,129,87,136,1,105,46,134,117,224,120,56,187,100,136,130,117,204,128,76,188,68,106,73,144,134,160,124,139,1,139,198,128,177,231,114,150,230,37,139,14,24,250,25,233,180,13,6,131,8,116,17,193,52,181,6,207,251,147,113,67,212,146,39,25,143,121,100,4,191,17,5,66,66,80,46,72,121,49,156,223,173,212,218,6,61,156,206,118,199,78,169,149,114,43,77,36,216,44,64,135,226,74,14,103,158,23,184,0,147,43,239,63,240,228,65,131,100,26,155,130,168,90,48,57,123,121,160,231,211,70,215,114,206,164,3,121,202,58,1,187,95,25,127,248,11,210,236,71,3,5,96,117,85,53,213,217,96,17,21,228,82,44,52,134,60,250,28,4,97,173,163,200,98,50,141,35,90,143,76,61,7,180,68,89,224,52,244,58,176,167,176,141,194,177,105,2,145,159,123,39,153,101,73,92,206,248,243,54,114,207,133,13,27,108,120,133,104,59,128,167,226,204,29,23,203,56,114,62,242,137,220,74,77,8,76,23,203,43,122,75,124,186,248,165,224,171,128,64,199,208,211,75,3,178,44,232,197,195,142,144,52,31,25,12,159,14,2,182,104,245,40,69,74,206,134,31,180,12,216,67,37,138,174,216,150,72,154,5,166,49,5,12,7,111,27,34,212,61,191,9,255,10,172,226,212,234,89,192,206,206,59,16,57,132,75,16,73,2,162,30,178,150,7,150,162,8,19,163,123,25,102,143,141,246,183,38,197,125,64,148,33,191,249,188,66,91,220,154,238,195,197,150,208,194,182,218,70,197,72,169,155,10,81,116,109,52,244,42,23,155,117,244,251,157,75,5,124,243,195,186,35,98,67,115,242,69,84,99,139,185,229,34,198,104,145,251,87,183,207,63,32,141,17,162,17,123,168,91,232,79,143,92,20,177,45,39,222,33,239,100,149,90,3,225,14,241,233,178,86,203,20,99,196,14,101,215,74,51,244,47,11,152,202,82,38,231,140,1,150,243,125,7,122,193,205,64,119,91,83,11,171,63,219,234,162,28,202,135,41,11,198,186,183,140,24,90,152,125,206,35,87,194,215,134,42,87,71,24,11,105,214,172,121,190,154,105,118,214,178,39,205,118,237,12,69,187,146,30,48,115,121,13,3,161,22,228,35,195,15,176,81,102,67,163,59,103,138,44,236,194,254,231,47,195,209,225,145,233,121,156,101,71,207,237,214,150,5,35,187,179,233,156,166,60,104,128,14,52,148,206,109,181,117,195,218,218,59,77,193,181,185,23,149,252,64,71,249,23,153,96,177,131,163,9,49,62,100,160,115,110,141,172,230,15,98,212,161,1,21,241,105,255,188,218,195,180,31,217,88,122,204,174,255,18,211,72,186,112,29,71,183,195,243,168,235,67,187,17,52,28,197,12,17,255,205,194,237,178,106,137,213,238,155,77,23,91,17,81,234,87,155,110,94,52,166,177,50,205,77,174,73,78,75,10,68,88,195,114,129,43,132,221,248,117,205,79,154,185,123,136,242,50,153,206,195,153,123,41,34,63,155,192,157,217,110,70,207,155,91,210,29,122,204,97,251,82,176,161,66,213,16,120,64,100,251,245,227,147,24,234,172,95,148,210,72,163,245,171,107,182,190,127,31,125,236,30,94,144,155,234,5,165,211,111,70,168,228,194,203,188,249,255,159,164,216,233,71,153,245,181,233,130,113,65,62,211,197,82,129,222,117,133,23,142,60,172,160,57,100,74,162,199,37,176,18,140,193,190,110,193,72,24,116,191,247,132,168,247,116,117,157,211,84,108,140,30,56,175,144,127,166,168,136,45,198,210,186,247,174,223,107,220,190,60,135,37,90,31,15,242,189,99,194,238,77,12,153,164,19,176,40,95,52,111,188,183,175,94,131,100,222,62,156,78,121,243,250,125,246,180,223,187,0,159,92,193,228,117,229,255,106,190,122,53,251,127,200,158,178,162,209,40,181,210,80,248,252,55,218,250,232,95,180,24,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bb18ef6c-25c9-43e3-b6da-de0755b0e432"));
		}

		#endregion

	}

	#endregion

}
