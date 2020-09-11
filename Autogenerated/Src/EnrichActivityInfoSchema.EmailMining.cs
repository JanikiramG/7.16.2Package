﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EnrichActivityInfoSchema

	/// <exclude/>
	public class EnrichActivityInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EnrichActivityInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EnrichActivityInfoSchema(EnrichActivityInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("32631f18-b4d5-4b3a-96de-3aa147def4d1");
			Name = "EnrichActivityInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c9ff5cbb-cb0e-4041-b483-395260757ab0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,83,223,107,219,48,16,126,78,161,255,195,145,66,137,25,216,239,203,15,24,94,233,250,208,173,44,121,27,123,80,236,115,162,97,73,153,36,23,178,210,255,125,39,91,182,229,204,43,105,217,32,36,209,167,251,238,190,251,238,36,153,64,115,96,25,194,6,181,102,70,21,54,78,149,44,248,174,210,204,114,37,47,47,158,46,47,38,149,225,114,7,235,163,177,40,230,39,231,248,107,37,45,23,24,175,81,115,86,242,95,53,143,162,40,238,74,227,142,14,144,150,204,152,247,112,35,53,207,246,31,50,203,31,185,61,222,201,66,81,12,125,146,36,129,133,169,132,96,250,184,242,231,38,22,115,64,193,120,9,156,130,181,168,83,199,45,35,9,40,223,62,50,203,72,185,213,44,179,223,9,56,84,219,146,103,144,185,202,227,133,159,106,137,157,198,7,173,14,168,45,71,18,250,208,144,155,128,83,117,53,176,217,163,87,198,124,86,224,57,146,17,5,71,29,119,180,80,98,163,241,30,197,22,245,236,51,25,15,75,152,182,236,187,124,26,57,217,173,238,219,138,231,208,9,206,231,47,72,233,156,202,168,125,202,247,54,33,158,60,170,35,109,239,94,37,67,82,230,215,11,112,199,161,4,99,181,219,182,180,191,247,50,174,80,230,205,240,134,147,188,71,187,87,249,89,99,92,24,68,200,52,22,203,169,223,230,47,219,31,152,217,248,230,103,197,74,51,83,245,41,154,38,171,241,70,188,68,245,72,175,135,108,135,173,82,37,12,184,64,63,17,184,71,52,153,240,2,28,10,203,37,200,170,44,91,120,162,209,86,90,66,65,44,215,27,33,207,245,247,159,107,235,178,109,84,170,196,129,105,231,154,203,198,198,246,123,30,22,12,24,103,86,246,120,191,128,129,33,93,182,184,191,142,224,250,186,95,147,209,224,238,54,170,11,61,255,255,169,132,195,24,183,242,173,131,121,201,158,115,92,249,39,102,220,162,253,196,204,62,85,57,206,254,238,69,141,52,122,205,106,145,180,255,198,150,151,75,11,131,164,222,6,223,237,44,104,119,163,214,245,171,164,152,119,65,135,61,28,13,229,133,93,158,60,219,6,29,130,132,253,6,54,87,144,247,154,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("32631f18-b4d5-4b3a-96de-3aa147def4d1"));
		}

		#endregion

	}

	#endregion

}
