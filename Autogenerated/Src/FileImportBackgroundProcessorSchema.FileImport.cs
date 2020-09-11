﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FileImportBackgroundProcessorSchema

	/// <exclude/>
	public class FileImportBackgroundProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FileImportBackgroundProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FileImportBackgroundProcessorSchema(FileImportBackgroundProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9711bf07-aff1-4f11-9cef-3bf614f18263");
			Name = "FileImportBackgroundProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,85,109,111,219,54,16,254,236,1,251,15,55,111,40,100,192,81,182,56,3,82,39,46,224,184,78,224,173,5,140,56,89,63,22,140,116,182,185,210,164,64,82,73,132,52,255,125,39,82,47,150,98,53,216,55,242,120,119,207,221,195,123,145,108,135,38,97,17,194,45,106,205,140,90,219,112,166,228,154,111,82,205,44,87,50,188,226,2,23,187,68,105,11,207,63,255,212,75,13,151,27,88,101,198,226,238,188,117,39,75,33,48,202,205,76,120,141,18,53,143,106,157,125,0,141,93,242,112,169,85,132,198,212,239,27,161,238,153,24,143,103,106,183,163,120,62,169,205,134,196,244,78,26,191,106,220,16,26,192,76,48,99,198,80,7,123,201,162,111,215,90,165,50,46,28,42,237,44,146,244,94,240,8,162,92,191,165,190,105,170,195,24,22,127,169,251,249,19,70,169,165,235,179,179,175,32,175,56,138,120,12,75,205,31,152,69,255,150,248,11,104,100,177,146,34,131,235,148,199,240,117,93,193,44,81,27,78,84,73,123,203,204,55,152,56,133,112,201,180,193,160,127,50,59,61,59,155,142,254,56,122,127,117,58,58,58,29,205,255,60,154,206,78,206,142,126,159,142,166,163,249,244,228,244,236,253,172,63,56,223,7,50,150,62,41,170,241,22,196,14,124,21,68,17,106,242,78,183,207,76,50,186,208,119,216,79,78,28,244,235,172,167,73,130,50,70,237,188,186,228,232,234,243,107,38,251,25,237,86,197,166,35,221,34,138,7,69,201,126,209,220,226,13,146,72,91,250,38,143,51,215,90,105,130,15,254,198,236,31,38,82,92,50,174,47,242,220,135,80,16,195,52,85,162,37,122,62,64,226,127,160,245,48,132,249,83,132,73,94,92,128,3,87,139,189,94,145,106,232,0,130,223,250,83,122,203,143,160,162,40,213,24,195,227,150,146,37,126,202,120,128,251,82,126,228,118,91,64,175,8,139,156,46,98,120,62,140,28,186,144,195,150,246,75,127,72,113,184,223,120,105,210,225,120,40,40,184,147,145,218,37,130,220,196,222,62,184,51,168,169,195,164,239,19,72,27,215,215,116,20,1,87,130,50,243,7,166,75,162,230,146,26,2,233,187,155,190,202,78,242,207,231,109,43,202,119,210,118,190,215,236,203,82,235,28,156,101,113,47,173,201,182,129,78,150,85,235,92,102,119,139,56,168,96,194,91,181,178,154,184,15,6,67,176,58,45,72,235,241,53,4,149,183,9,200,84,136,50,185,158,70,155,106,233,245,94,170,200,81,224,142,90,167,198,118,168,87,66,61,206,253,203,101,182,138,182,184,99,197,53,15,163,179,249,6,192,12,20,17,79,137,176,7,110,179,58,176,10,202,7,6,223,191,87,178,112,69,229,158,26,248,101,82,154,123,65,120,147,74,153,151,216,187,119,240,150,170,171,215,193,15,210,45,218,72,167,50,111,155,118,13,120,205,230,7,204,138,58,243,243,42,167,187,12,130,104,24,190,42,163,206,194,109,34,255,159,114,164,77,98,104,214,208,247,212,101,148,79,32,47,158,63,17,243,198,173,134,25,205,43,139,135,148,130,67,194,219,44,161,181,32,152,196,248,6,137,228,90,167,35,173,106,44,44,228,90,5,69,88,141,140,223,158,115,110,77,248,199,227,227,99,184,224,114,75,235,204,198,138,118,135,198,245,164,191,191,27,250,199,31,28,143,126,183,56,26,253,19,190,217,238,31,185,59,49,157,93,24,215,37,67,80,247,255,210,51,205,193,138,245,125,150,53,38,202,112,2,205,136,104,137,143,175,38,198,77,165,16,52,209,6,175,102,0,182,71,93,222,215,53,64,190,52,190,208,160,44,103,65,53,203,130,194,213,154,22,54,139,182,16,236,207,149,166,71,224,178,27,173,106,0,75,217,20,199,94,231,228,108,115,247,163,105,93,4,216,123,129,136,217,60,194,3,203,163,234,178,142,101,213,181,135,106,231,117,195,30,174,43,47,109,10,73,246,31,77,143,152,126,117,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9711bf07-aff1-4f11-9cef-3bf614f18263"));
		}

		#endregion

	}

	#endregion

}

