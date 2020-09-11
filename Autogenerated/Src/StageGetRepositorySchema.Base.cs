﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: StageGetRepositorySchema

	/// <exclude/>
	public class StageGetRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public StageGetRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public StageGetRepositorySchema(StageGetRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("602bf7f9-b3e3-4f06-8629-f23daa6cba77");
			Name = "StageGetRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,86,75,111,219,56,16,62,171,64,255,3,235,94,36,192,144,239,241,163,72,236,166,245,34,77,130,56,187,151,69,81,208,210,216,21,32,145,94,62,12,184,65,254,251,14,31,178,245,116,157,94,44,115,56,243,205,204,55,195,33,25,45,64,238,104,2,228,25,132,160,146,111,84,60,231,108,147,109,181,160,42,227,236,253,187,151,247,239,2,45,51,182,37,171,131,84,80,140,27,235,120,65,21,61,9,231,188,40,56,171,174,5,212,87,241,226,166,33,248,204,84,166,50,144,13,241,45,77,20,23,78,142,59,31,5,108,49,34,50,207,169,148,87,228,11,168,149,162,91,120,130,29,151,25,42,30,172,214,104,52,34,19,169,139,130,138,195,204,175,31,5,223,103,41,72,82,128,250,201,83,73,20,39,124,173,104,198,136,52,16,50,46,13,71,13,203,137,58,236,96,71,5,45,8,67,170,166,131,103,27,235,193,228,60,152,153,223,201,232,168,98,140,254,93,192,134,234,92,221,100,44,197,68,66,179,201,55,225,18,163,61,5,58,113,36,217,240,13,198,44,26,146,123,132,39,83,235,5,245,237,86,205,38,138,190,35,252,78,175,243,44,33,137,161,128,180,149,136,165,229,140,35,130,24,47,150,167,19,157,156,73,37,180,161,26,89,125,180,14,156,134,119,214,118,19,254,45,65,160,29,131,196,244,8,209,181,229,208,89,124,205,164,209,93,129,82,166,162,178,45,139,140,147,32,184,34,107,42,33,108,130,116,24,196,22,120,149,252,132,130,26,190,34,242,98,33,186,252,77,187,0,76,131,5,175,62,127,96,169,163,160,206,7,54,203,14,132,105,199,43,243,95,97,60,144,122,66,202,101,103,134,93,178,23,178,5,53,38,175,165,125,182,167,10,136,235,33,151,7,249,33,237,119,137,85,160,44,129,113,211,85,77,121,85,211,37,211,89,211,156,124,250,68,194,166,108,74,230,2,208,113,221,58,140,162,241,121,42,190,185,227,98,120,176,129,215,179,88,115,158,147,175,84,174,116,146,128,148,27,157,207,121,174,11,22,150,101,17,160,180,96,141,152,99,167,36,227,91,60,33,55,7,83,198,176,131,57,87,234,101,11,220,149,253,3,30,20,157,231,213,114,118,114,219,157,118,61,188,122,47,199,85,251,111,148,97,16,194,134,90,154,255,46,228,74,119,118,133,183,231,89,74,174,211,116,145,201,93,78,15,158,177,21,228,232,158,72,251,41,227,219,83,65,210,170,154,31,17,13,62,241,100,98,121,204,208,90,52,149,67,23,66,144,109,72,216,176,90,202,59,158,208,60,251,69,215,249,241,28,89,151,185,151,27,54,60,141,93,62,239,90,106,165,183,30,20,31,125,123,35,54,59,222,244,139,70,122,18,45,4,48,101,11,131,163,84,11,88,166,104,217,40,212,252,164,21,227,77,116,212,244,72,142,75,223,109,225,173,102,9,230,124,143,77,19,58,81,188,226,90,36,224,247,187,195,29,182,249,143,134,14,62,8,186,96,26,52,245,97,68,81,124,45,195,182,220,67,199,127,241,140,133,230,231,25,111,143,248,14,54,234,65,43,16,195,30,86,75,187,32,126,232,9,97,176,76,7,17,230,255,249,63,77,243,222,100,7,79,144,112,145,26,221,35,226,53,75,251,245,171,180,87,240,61,51,143,230,78,4,140,59,236,42,104,228,187,229,149,64,46,161,108,192,122,213,46,164,179,155,76,15,127,193,196,175,140,185,158,113,207,247,248,58,194,23,4,241,7,213,188,61,236,191,176,122,88,93,240,216,169,230,62,139,43,58,227,147,74,245,40,92,48,67,156,165,3,118,12,149,220,200,74,33,122,129,30,68,106,206,76,171,193,144,176,55,218,188,201,237,82,226,196,164,249,27,29,247,89,197,183,130,23,151,15,92,59,237,58,175,165,168,187,203,46,76,169,243,38,186,44,175,78,211,74,127,6,173,11,193,223,4,227,234,69,229,100,245,75,165,213,160,141,7,159,233,84,243,13,151,230,247,9,40,214,150,8,251,169,118,174,0,137,231,178,210,185,214,198,235,149,65,24,149,248,94,23,107,132,152,122,16,163,235,66,254,135,230,26,38,25,83,179,203,91,171,134,140,211,131,165,189,192,230,177,113,6,185,221,59,53,108,79,174,133,234,117,129,175,96,196,155,53,167,206,217,251,245,226,150,59,38,121,210,249,243,92,127,219,79,190,99,156,211,51,143,94,39,173,11,81,246,63,41,228,9,40,22,14,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("602bf7f9-b3e3-4f06-8629-f23daa6cba77"));
		}

		#endregion

	}

	#endregion

}
