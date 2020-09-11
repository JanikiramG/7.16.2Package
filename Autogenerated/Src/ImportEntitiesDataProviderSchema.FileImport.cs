﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ImportEntitiesDataProviderSchema

	/// <exclude/>
	public class ImportEntitiesDataProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ImportEntitiesDataProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ImportEntitiesDataProviderSchema(ImportEntitiesDataProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b3e62edd-3aed-4f53-ac07-92e86719d429");
			Name = "ImportEntitiesDataProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,213,25,219,110,227,54,246,217,5,250,15,172,219,7,9,53,148,105,223,54,23,7,78,156,180,70,39,205,116,50,51,251,176,40,6,140,68,219,218,145,41,15,73,57,241,14,252,239,61,36,143,36,82,23,219,65,7,216,221,151,200,188,156,251,149,39,156,174,152,92,211,152,145,119,76,8,42,243,185,138,174,115,62,79,23,133,160,42,205,121,116,155,102,108,182,90,231,66,125,251,205,151,111,191,25,20,50,229,11,242,176,149,138,173,206,26,107,0,205,50,22,107,56,25,253,194,56,19,105,220,186,243,58,229,159,235,205,235,124,181,202,185,187,22,204,95,69,211,171,198,198,13,87,169,74,153,172,183,93,230,225,194,45,141,85,46,236,13,184,243,189,96,11,96,137,144,235,140,74,121,74,172,56,37,150,41,85,244,141,200,55,105,194,4,92,254,215,148,205,105,145,169,171,148,39,128,58,80,219,53,203,231,193,172,31,40,28,145,223,65,141,228,130,112,248,232,187,253,87,195,63,129,196,186,120,204,210,152,196,154,155,61,204,0,163,123,57,213,214,168,100,3,163,73,69,185,2,241,222,136,116,67,21,51,162,15,214,118,65,98,125,78,82,174,200,29,125,126,67,5,112,170,152,144,215,121,193,213,27,38,254,40,152,216,94,47,11,254,9,196,248,233,31,175,94,157,245,2,191,205,159,110,115,49,227,146,137,54,228,43,3,217,134,149,74,104,59,125,124,44,230,115,38,88,226,8,182,125,136,151,108,69,81,133,195,171,142,27,67,196,249,61,227,137,149,23,215,165,97,111,83,150,37,125,162,91,76,175,243,197,130,9,242,49,51,95,79,60,151,13,242,81,154,175,119,97,6,126,93,172,184,156,44,22,64,145,130,111,89,15,219,146,143,113,207,201,1,248,73,66,215,74,179,131,240,96,214,152,73,153,251,140,9,70,147,156,103,219,74,125,169,85,202,115,204,50,48,195,140,39,236,89,235,108,214,222,62,164,50,227,47,162,208,188,106,189,25,143,68,181,89,239,236,119,189,224,61,152,30,224,185,141,116,82,120,203,144,24,191,28,52,46,93,52,174,25,57,7,51,14,216,105,150,254,135,89,243,4,161,217,223,125,21,78,70,123,244,222,84,123,72,78,137,90,166,50,48,108,13,186,69,106,25,11,164,234,180,223,1,185,250,108,2,72,214,16,84,32,100,159,39,247,202,115,221,226,108,220,246,45,114,121,105,197,11,186,36,233,243,241,75,200,228,170,117,216,80,125,24,158,29,98,181,12,153,222,3,135,229,246,97,139,245,14,120,155,223,113,169,185,62,239,229,98,28,180,57,118,211,4,126,52,75,54,97,0,3,36,40,127,67,166,103,79,30,192,33,117,52,28,181,177,252,66,22,76,157,145,3,238,113,199,212,50,239,205,114,83,150,65,70,39,32,117,87,6,181,167,38,87,7,249,227,191,129,46,177,185,228,1,204,15,200,103,137,22,170,200,178,210,215,55,84,144,196,162,180,210,90,12,77,57,173,81,162,91,145,175,130,3,201,221,134,192,32,157,147,160,73,250,59,159,246,192,18,142,254,185,4,108,1,102,183,234,246,48,140,102,242,230,115,65,179,192,90,55,170,202,89,19,113,136,52,119,230,175,96,170,16,28,165,242,242,76,233,1,166,166,245,169,208,158,90,21,186,90,234,146,186,244,16,3,210,212,89,52,227,42,63,82,91,200,115,215,221,78,9,110,120,177,98,130,62,102,236,220,251,237,192,141,199,90,66,63,169,154,250,45,131,94,16,194,240,226,200,26,168,125,209,154,98,76,62,177,45,198,156,209,81,165,165,18,193,235,20,186,129,139,106,25,189,203,245,14,230,71,115,19,227,27,47,214,248,220,171,213,229,21,54,51,18,58,145,178,9,185,163,106,25,77,30,101,112,168,211,57,33,129,67,44,50,55,200,143,228,231,210,109,122,145,223,165,60,216,215,9,141,218,124,121,92,199,70,221,150,222,5,132,3,87,161,193,123,205,210,76,247,156,174,178,144,45,224,53,201,161,30,178,176,31,53,58,139,7,253,176,206,82,117,207,1,66,201,192,161,27,118,185,143,134,56,255,165,72,19,227,34,128,95,194,70,233,117,85,84,73,207,253,101,181,141,78,95,35,113,173,42,153,126,24,224,149,7,179,104,197,197,20,32,83,14,7,101,90,177,150,239,200,0,47,79,59,246,157,16,152,180,246,120,243,204,226,66,153,170,231,243,0,79,11,89,8,54,189,170,183,160,80,148,105,201,197,1,93,200,91,232,206,76,49,176,178,69,22,43,179,219,65,77,165,70,48,120,90,194,107,10,44,89,65,71,250,227,144,24,12,106,125,70,147,36,113,175,86,101,248,3,205,10,134,42,110,235,6,5,46,179,30,126,188,20,88,211,232,242,130,77,158,38,164,221,193,32,139,93,169,241,129,110,64,103,55,66,128,74,127,188,192,226,25,253,74,121,146,49,179,123,7,4,233,162,51,233,34,53,120,43,106,44,126,90,122,151,79,175,190,110,82,194,171,90,119,205,2,232,58,117,234,128,203,222,44,228,85,179,242,28,106,211,106,173,182,142,77,173,210,221,74,212,145,16,251,82,114,37,163,207,19,146,247,66,125,34,117,94,128,7,120,22,132,176,184,23,137,182,83,21,76,144,170,38,89,86,33,188,162,42,94,234,6,167,242,60,5,61,84,181,176,106,168,75,158,101,241,96,93,60,171,224,231,240,16,167,64,33,168,245,137,181,49,173,83,148,97,194,113,126,80,104,141,45,50,126,46,93,164,131,135,125,60,56,209,33,3,151,228,200,149,100,84,99,3,114,29,74,109,241,1,68,219,113,54,194,70,54,50,47,169,190,206,163,19,87,215,51,174,66,87,55,51,166,46,184,98,68,229,101,23,251,174,250,229,146,193,92,228,232,110,71,98,99,241,64,147,93,155,182,147,185,154,191,231,7,34,59,208,153,219,141,230,155,13,152,113,34,22,210,181,223,160,161,39,240,155,134,106,92,253,215,188,64,75,224,30,32,9,189,29,225,239,90,98,71,168,50,213,117,150,51,147,90,142,247,24,175,129,243,221,7,59,195,182,23,29,221,8,97,68,217,225,66,157,88,112,218,128,149,206,166,99,63,116,98,29,47,78,254,193,218,25,196,224,212,161,142,95,236,130,79,73,172,249,4,239,56,37,41,116,49,63,133,117,6,170,219,42,253,98,69,98,103,245,89,138,131,132,56,50,8,206,154,80,56,155,249,97,104,33,191,152,251,187,161,115,47,97,186,116,83,52,165,133,138,166,245,166,140,110,83,33,213,189,192,233,90,229,152,58,129,122,192,141,167,192,64,45,69,254,100,186,6,112,53,208,53,87,191,195,249,189,48,89,182,242,159,0,71,111,14,170,42,72,118,14,155,80,77,141,181,223,109,215,90,34,207,28,186,192,94,109,181,172,46,26,212,150,105,37,162,169,11,223,82,147,57,169,28,30,99,246,22,148,229,184,25,118,156,161,3,188,209,251,144,157,117,172,85,202,67,92,86,27,164,244,247,75,95,2,208,240,220,44,202,243,211,214,32,192,208,255,224,80,112,101,27,185,196,42,139,52,178,85,237,2,29,57,202,229,125,228,51,231,61,190,142,127,218,230,10,220,155,37,101,36,227,210,198,242,225,28,213,157,159,88,249,235,200,38,230,18,226,96,147,127,98,129,30,9,141,28,112,63,203,84,188,165,66,193,115,148,60,230,121,70,254,135,186,24,89,196,218,9,192,167,148,40,208,93,177,55,211,83,125,140,234,6,2,104,112,30,204,180,177,12,81,167,45,104,148,114,96,186,255,41,55,184,206,24,237,178,87,90,21,231,154,105,4,217,215,6,250,116,71,174,54,90,58,64,199,219,87,241,106,221,204,105,38,203,88,254,42,69,240,248,10,216,93,254,122,107,223,206,27,103,160,37,53,115,240,51,240,7,6,40,222,49,83,199,58,246,156,33,240,201,201,9,57,151,197,106,69,197,118,92,110,104,139,10,105,162,156,204,225,233,69,186,148,69,148,118,93,242,184,37,107,59,165,77,200,249,90,231,11,193,230,230,31,36,23,195,134,58,134,228,164,34,113,126,210,36,106,129,123,32,199,231,39,230,216,220,198,113,177,201,20,251,156,111,95,216,252,237,240,168,102,102,71,12,226,122,162,0,167,95,141,22,110,175,55,255,223,251,173,63,241,175,77,120,159,53,172,247,150,62,233,34,28,220,22,60,54,79,224,17,206,97,235,73,207,152,204,161,230,53,119,53,64,169,175,134,205,36,176,146,212,227,13,107,188,61,211,15,167,118,243,92,77,98,157,252,45,92,3,19,78,48,65,152,139,126,166,224,56,172,218,30,212,101,217,229,165,26,208,127,103,132,46,249,207,102,228,100,206,111,158,215,194,18,54,131,24,135,175,102,98,214,45,87,55,32,206,154,198,228,85,221,127,189,212,169,171,230,252,224,16,151,247,112,209,196,208,124,203,236,254,107,241,160,253,45,50,141,231,223,13,5,219,214,190,48,44,246,246,23,13,207,34,235,234,231,136,188,228,149,130,47,146,174,209,88,61,88,187,163,156,46,236,72,106,102,254,239,28,179,171,237,251,89,18,212,84,225,177,154,43,123,251,125,149,219,176,58,245,200,224,0,119,215,121,231,194,172,43,119,238,246,21,175,37,139,63,17,186,161,105,102,10,20,224,45,71,205,240,5,183,143,142,172,65,53,67,38,90,134,227,223,90,152,220,170,100,224,173,220,114,252,150,73,120,252,232,142,63,133,42,202,224,98,121,210,52,243,7,188,242,155,79,77,207,4,72,131,131,67,255,140,192,127,108,95,160,115,190,212,172,230,65,116,220,144,213,25,223,131,255,244,131,248,207,93,13,149,81,169,42,81,235,127,171,70,19,190,13,98,157,4,227,200,214,99,231,21,218,80,195,110,232,59,153,135,114,95,35,132,106,55,93,62,49,121,192,78,46,197,121,103,130,24,119,182,61,78,110,209,180,44,41,151,18,236,252,5,34,63,61,192,109,35,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b3e62edd-3aed-4f53-ac07-92e86719d429"));
		}

		#endregion

	}

	#endregion

}
