﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FileApiServiceSchema

	/// <exclude/>
	public class FileApiServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FileApiServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FileApiServiceSchema(FileApiServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5e0f9e02-cda8-44e6-ab50-10799e7ecc21");
			Name = "FileApiService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("26f9ddf3-cac5-44df-a1e0-ef0f21aab8cf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,85,81,79,219,48,16,126,14,18,255,193,42,47,169,212,165,211,132,54,13,104,165,174,133,173,147,74,81,82,196,3,154,144,219,92,59,139,196,246,108,7,86,33,254,251,206,118,66,211,210,192,158,218,251,252,249,206,119,223,221,133,211,28,180,164,11,32,51,80,138,106,177,52,209,80,240,37,91,21,138,26,38,248,225,193,211,225,65,80,104,198,87,36,89,107,3,121,52,158,158,238,66,9,168,7,182,128,137,72,33,123,243,48,26,44,12,123,112,158,223,230,221,192,252,21,1,49,36,105,141,151,19,67,13,108,8,13,143,143,46,88,6,215,50,19,52,221,207,85,13,62,20,68,23,116,97,132,98,160,247,49,236,75,134,34,207,235,89,236,59,173,114,138,69,97,144,211,68,254,97,140,140,6,115,109,20,6,197,119,219,152,72,61,82,176,66,139,12,51,170,245,9,177,201,12,36,43,93,58,198,237,8,150,180,200,76,45,12,116,72,162,101,29,248,101,137,37,128,229,113,65,28,54,208,242,18,12,190,84,98,181,230,44,99,102,29,195,159,130,41,200,129,27,29,214,13,171,10,233,145,119,174,88,86,84,2,105,219,6,145,197,60,99,11,178,176,41,236,100,64,78,200,55,170,161,180,58,100,28,3,77,167,60,91,215,53,70,23,79,46,213,151,106,92,41,33,65,25,84,230,4,255,219,102,242,181,8,164,55,92,148,24,164,208,12,5,92,147,187,229,150,237,75,27,116,187,93,114,166,139,60,167,106,221,175,0,123,147,228,148,211,21,168,232,133,213,173,211,26,130,236,152,118,102,130,96,5,166,252,23,176,37,9,119,30,66,122,61,194,139,44,107,87,156,224,21,193,43,239,59,113,29,125,7,115,182,29,167,31,150,55,3,14,143,4,181,197,14,42,44,121,160,86,133,21,36,108,21,26,20,30,112,112,141,213,234,144,235,45,160,221,62,245,46,158,253,143,2,83,40,190,167,102,21,229,185,20,3,120,234,245,216,22,103,2,230,183,72,173,50,78,247,55,106,237,199,82,19,27,169,161,214,14,145,84,209,156,112,220,83,189,150,229,218,14,182,173,214,234,59,181,82,106,40,193,180,129,230,209,89,215,145,55,119,125,54,186,239,99,17,5,26,103,5,105,21,110,137,183,83,236,38,183,45,234,179,17,220,226,92,142,249,131,184,135,208,231,132,106,180,174,166,201,204,150,80,177,25,228,50,179,125,128,168,247,142,120,140,171,20,53,128,11,161,114,106,240,8,125,76,176,151,177,157,60,20,253,212,88,114,231,191,156,11,124,185,93,7,222,69,152,184,60,72,45,205,170,57,198,155,77,54,230,75,225,40,53,179,161,83,54,140,170,83,26,251,164,22,19,51,169,191,160,115,120,112,132,237,123,121,62,75,102,131,203,209,32,30,125,186,251,72,176,188,179,233,104,74,134,241,228,195,241,231,227,175,95,222,241,175,112,41,128,182,190,237,178,115,190,255,226,166,45,148,194,99,183,50,240,212,197,130,76,195,127,59,179,148,218,215,193,250,46,125,221,40,42,81,217,112,231,180,41,178,15,205,83,182,124,39,182,70,11,5,125,53,73,209,141,80,247,238,83,138,62,181,40,212,2,18,79,173,102,204,238,128,237,249,141,188,64,22,12,183,21,109,191,108,133,114,34,91,211,251,86,109,12,43,216,247,79,116,158,75,227,167,116,255,124,122,116,27,124,254,7,67,20,104,74,252,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5e0f9e02-cda8-44e6-ab50-10799e7ecc21"));
		}

		#endregion

	}

	#endregion

}

