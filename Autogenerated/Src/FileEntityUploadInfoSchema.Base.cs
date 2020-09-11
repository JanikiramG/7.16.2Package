namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FileEntityUploadInfoSchema

	/// <exclude/>
	public class FileEntityUploadInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FileEntityUploadInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FileEntityUploadInfoSchema(FileEntityUploadInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d770075c-2aa0-4a74-8063-064d78bec922");
			Name = "FileEntityUploadInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("be1f674b-cdb4-46e4-8c46-23cae20b9205");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,83,77,107,219,64,16,61,59,144,255,48,36,151,4,140,33,215,166,41,164,137,29,4,37,53,181,147,158,215,210,72,222,102,181,43,118,87,164,162,248,191,119,246,67,177,36,151,34,221,180,243,230,189,121,154,15,201,74,52,21,75,17,182,168,53,51,42,183,139,7,37,115,94,212,154,89,174,228,98,197,5,190,84,66,177,236,252,236,207,249,217,172,54,92,22,176,105,140,197,242,118,240,38,170,16,152,58,158,89,60,161,68,205,211,147,156,228,251,49,116,44,250,19,119,247,85,69,8,97,85,189,19,60,133,84,48,99,192,213,95,74,203,109,19,92,36,50,87,240,9,146,163,47,23,33,150,51,55,187,212,88,80,117,88,7,9,250,21,99,117,157,90,165,141,151,110,181,255,165,122,69,169,206,20,250,248,38,221,99,201,158,169,63,115,120,170,121,6,57,81,146,108,14,49,203,61,61,234,84,103,59,165,4,112,243,176,175,229,27,102,65,19,238,32,103,194,16,63,162,43,174,141,245,41,4,145,45,188,6,111,122,182,28,84,36,120,104,226,214,39,174,188,7,39,236,63,142,193,200,106,77,5,128,166,81,151,50,66,23,143,204,178,139,0,36,39,70,7,214,219,180,158,227,238,15,132,132,109,83,5,59,206,130,239,181,241,251,226,226,47,173,189,87,212,198,141,228,14,110,124,224,16,6,113,137,50,11,195,138,239,254,228,214,90,85,168,45,199,254,220,98,243,191,54,22,127,48,89,96,108,96,129,54,126,205,236,94,171,119,144,248,14,207,202,38,101,37,176,164,94,98,182,252,157,98,229,54,243,234,58,248,58,116,204,244,213,59,125,251,144,15,28,19,63,250,180,141,213,200,74,183,108,150,74,141,227,60,114,127,38,76,55,159,67,213,57,168,221,47,186,157,47,112,159,101,220,99,98,205,52,43,205,56,193,232,253,100,149,70,145,253,130,199,229,154,82,237,99,245,70,145,252,25,12,119,111,10,179,179,142,83,92,82,27,105,46,83,167,234,123,210,165,190,50,81,143,228,102,152,242,146,9,216,42,203,132,107,210,55,148,133,221,79,40,28,79,107,20,129,211,210,181,87,246,127,66,247,232,92,236,240,23,60,204,200,123,0,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d770075c-2aa0-4a74-8063-064d78bec922"));
		}

		#endregion

	}

	#endregion

}

