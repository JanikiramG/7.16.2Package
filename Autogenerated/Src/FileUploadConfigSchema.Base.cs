﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FileUploadConfigSchema

	/// <exclude/>
	public class FileUploadConfigSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FileUploadConfigSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FileUploadConfigSchema(FileUploadConfigSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4c6e2518-0cf7-4e94-8e41-3b46b64c02f8");
			Name = "FileUploadConfig";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,150,221,111,218,48,16,192,159,153,180,255,225,196,94,90,105,10,239,229,67,234,216,168,144,182,14,13,214,215,201,36,151,224,213,31,145,237,76,99,168,255,251,108,39,5,98,2,93,39,37,47,136,220,231,47,119,103,231,4,225,168,115,18,35,172,80,41,162,101,106,162,169,20,41,205,10,69,12,149,34,154,81,134,223,115,38,73,2,187,183,111,122,133,166,34,131,229,86,27,228,195,224,217,122,50,134,177,115,211,209,29,10,84,52,62,177,153,127,61,136,142,115,114,46,133,213,88,221,59,133,153,13,1,83,70,180,190,129,3,64,9,230,109,242,98,205,104,12,177,51,57,177,128,27,152,159,200,118,222,111,31,124,70,145,37,54,250,66,209,95,196,96,169,204,203,7,80,72,18,41,216,246,56,204,92,164,18,126,164,181,231,97,21,19,69,82,134,173,231,176,153,181,81,69,108,164,114,153,60,114,105,49,24,12,96,164,11,206,137,218,78,158,5,48,181,121,13,106,160,214,141,8,219,19,153,130,217,230,104,77,17,33,86,152,142,251,225,123,245,7,147,104,31,113,16,134,28,229,68,17,14,194,118,121,220,175,179,247,39,71,81,131,247,180,65,71,3,239,234,35,85,197,14,83,95,133,213,169,39,184,246,243,210,235,213,165,209,116,131,241,227,173,202,10,142,194,220,23,140,93,57,58,153,94,5,222,215,67,239,29,84,28,198,112,210,130,94,239,233,114,31,22,74,230,168,12,197,127,233,194,136,138,141,29,92,147,200,248,180,56,47,213,188,170,84,130,49,229,132,193,23,242,219,249,46,233,31,132,29,100,104,134,160,221,207,83,203,249,215,82,50,88,162,153,22,218,72,110,79,101,193,133,158,41,247,183,60,11,29,178,132,67,18,60,142,39,103,14,213,235,129,170,201,189,140,99,15,164,187,121,62,9,67,205,118,25,111,144,147,123,59,127,13,28,81,104,211,9,88,217,172,115,72,7,109,39,48,206,235,28,202,179,174,93,144,187,130,38,30,99,158,156,131,152,39,29,32,172,236,53,220,140,80,106,254,27,225,149,55,202,74,26,194,156,247,103,20,153,217,52,2,213,77,218,38,171,70,101,65,148,189,207,47,79,111,104,211,54,154,239,220,113,210,7,194,138,23,201,188,81,219,104,31,169,95,147,172,116,84,22,240,61,200,245,79,187,59,77,224,54,73,168,215,177,133,251,2,235,38,222,208,166,109,220,165,177,171,9,119,11,141,177,117,106,190,153,188,170,109,16,255,101,155,235,233,166,16,143,152,84,123,105,3,78,96,210,209,33,248,176,53,248,141,136,172,113,198,246,202,182,97,168,237,208,3,42,237,86,159,6,142,74,213,81,167,102,84,105,227,123,209,220,166,131,190,121,153,46,215,147,186,208,202,254,2,100,101,132,213,184,12,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4c6e2518-0cf7-4e94-8e41-3b46b64c02f8"));
		}

		#endregion

	}

	#endregion

}
