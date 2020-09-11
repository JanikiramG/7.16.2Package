﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SspUserAdministratorSchema

	/// <exclude/>
	public class SspUserAdministratorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SspUserAdministratorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SspUserAdministratorSchema(SspUserAdministratorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("623e144d-2bff-4944-aa0a-346ec2a0efa2");
			Name = "SspUserAdministrator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7cc31540-fa76-4c79-9b86-a6eabd8e662c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,26,77,111,227,184,245,236,5,246,63,112,189,23,25,8,148,158,103,38,238,58,78,118,234,34,147,4,241,100,231,80,20,45,35,209,182,58,178,228,21,165,100,188,65,254,123,31,31,73,137,164,40,89,158,73,119,11,180,151,196,162,222,23,31,223,55,149,209,45,227,59,26,49,242,145,21,5,229,249,170,12,231,121,182,74,214,85,65,203,36,207,194,229,242,246,251,239,158,191,255,110,84,241,36,91,147,229,158,151,108,251,214,121,6,156,52,101,145,64,224,225,123,150,177,34,137,122,97,110,30,254,5,63,63,228,49,75,91,112,87,73,246,107,179,104,202,181,221,230,153,255,77,193,186,214,195,139,243,206,87,151,89,153,148,9,227,62,128,79,236,161,197,81,10,184,100,101,9,79,156,156,17,164,226,232,107,207,53,0,32,2,234,143,5,91,195,11,50,79,41,231,111,200,146,239,238,57,43,102,241,54,201,18,94,2,86,94,32,220,233,233,41,121,199,171,237,150,22,251,169,122,70,28,178,202,11,18,21,140,10,162,36,202,179,146,70,37,161,89,76,42,32,196,67,141,123,106,32,39,89,201,138,140,166,36,66,10,62,166,228,13,89,248,133,25,61,163,64,181,228,183,69,190,99,133,80,212,27,241,187,132,147,99,177,4,113,133,198,5,65,82,200,153,201,211,14,107,64,83,194,209,78,83,66,248,121,13,238,62,62,147,53,43,223,146,23,201,112,87,36,143,180,100,228,125,149,196,228,31,156,239,238,242,188,124,95,228,213,110,17,191,237,145,105,150,166,100,151,23,37,168,4,181,70,214,2,231,160,104,200,102,105,113,33,194,25,70,35,16,138,156,33,244,104,228,200,65,126,56,67,196,240,114,187,43,247,18,100,244,103,87,90,181,254,198,93,7,179,178,53,0,14,85,138,247,120,74,247,89,162,1,3,1,246,113,191,99,194,71,39,111,145,30,71,169,60,36,31,105,90,161,143,140,94,122,180,4,198,43,185,148,73,138,158,33,237,231,160,154,218,120,237,21,251,28,127,100,89,44,205,203,182,53,216,54,216,97,21,129,33,130,181,237,170,135,52,137,122,4,94,128,58,18,154,38,191,1,3,74,50,246,68,18,192,167,25,4,180,124,69,202,13,3,20,198,132,247,172,206,198,62,107,31,159,78,251,247,136,18,120,29,40,112,12,181,178,30,39,202,78,28,160,51,7,76,30,91,91,91,103,184,153,214,122,48,49,207,176,75,137,31,88,185,201,99,225,172,232,44,61,250,155,139,176,2,236,76,45,105,158,160,90,161,157,130,69,121,17,119,168,7,87,118,180,160,91,146,65,42,57,27,171,240,180,136,199,211,185,138,84,73,204,32,206,174,18,86,132,239,78,17,214,143,42,254,142,167,24,60,196,207,126,96,26,69,121,149,105,3,31,79,103,242,89,186,117,47,203,130,149,85,145,113,201,200,2,212,111,90,113,70,106,73,32,4,248,92,111,242,132,128,45,136,168,44,132,58,145,192,182,100,29,102,192,49,147,180,108,195,113,252,217,110,103,60,45,61,56,210,124,30,105,33,40,214,199,230,90,15,44,5,62,142,58,104,24,112,33,36,175,11,182,130,92,93,109,179,95,68,208,208,54,103,131,93,195,134,5,27,248,231,121,59,215,10,2,144,90,89,62,102,198,131,136,100,200,16,112,2,200,95,19,247,101,40,132,247,16,153,193,94,30,5,22,196,141,14,97,212,126,5,21,77,221,12,158,126,201,230,85,10,246,192,112,19,118,230,23,17,25,69,117,66,192,9,25,131,203,9,231,80,184,227,19,35,17,248,212,120,139,41,73,25,47,114,178,205,71,162,128,188,100,75,191,220,66,152,122,2,95,156,173,89,143,72,190,131,6,193,62,88,248,32,216,159,148,60,201,138,4,14,241,41,188,84,118,235,136,171,128,46,191,236,146,130,93,8,7,57,35,226,223,199,4,28,246,190,140,174,243,167,112,22,199,23,116,207,29,162,138,219,139,71,213,244,145,105,27,147,46,104,25,115,168,180,224,20,0,143,121,237,152,166,161,44,178,187,60,101,210,77,69,164,21,62,138,15,5,44,55,238,104,121,140,0,67,52,143,223,40,122,71,59,166,123,216,53,143,33,14,102,0,155,162,196,42,123,180,92,201,15,127,135,59,6,28,185,245,110,156,70,255,221,58,182,139,15,238,81,176,63,238,213,39,212,48,12,52,154,93,87,41,37,244,33,56,44,28,4,247,204,134,177,233,194,146,255,135,66,251,36,115,148,217,180,63,239,100,210,152,18,240,217,171,36,186,165,209,103,186,102,92,132,212,64,21,26,139,236,49,1,28,36,159,173,114,173,77,225,171,122,13,250,164,136,101,156,9,180,112,193,175,243,242,186,74,211,155,2,99,77,48,169,29,88,185,148,48,108,143,8,207,196,71,143,188,152,222,170,40,180,138,145,208,146,95,224,241,86,64,108,215,168,168,150,129,245,203,161,242,79,151,47,230,201,224,134,134,150,43,122,243,227,233,53,232,167,194,198,5,59,45,144,34,166,37,253,234,242,65,150,141,143,73,81,86,208,114,160,131,220,193,230,32,80,20,88,71,244,159,179,225,93,162,203,108,202,143,250,176,230,77,9,82,175,9,136,107,44,68,234,37,39,191,88,230,236,186,180,101,249,2,121,214,235,110,30,255,180,36,17,111,248,164,163,190,13,239,88,154,211,216,60,183,57,141,54,237,132,106,187,97,219,126,119,134,241,129,170,60,30,85,235,182,73,119,22,18,52,107,25,56,78,237,47,109,89,33,161,9,177,208,63,162,150,141,15,72,6,122,27,39,170,231,51,249,79,60,158,102,4,249,190,110,13,54,203,117,228,105,23,190,3,61,128,106,219,104,106,232,33,213,115,79,189,125,200,15,64,108,101,82,231,251,218,50,3,51,135,116,228,105,48,146,37,19,6,160,243,52,62,56,199,49,9,101,106,13,198,203,217,61,148,57,99,216,217,36,252,185,200,183,129,221,218,76,194,25,151,64,19,121,44,225,167,13,43,88,141,103,151,141,0,190,224,151,191,194,38,2,73,63,196,78,53,104,213,146,19,77,109,150,197,53,45,111,157,91,243,237,38,220,26,101,181,42,230,240,166,88,83,104,73,49,100,121,121,59,33,160,107,35,141,234,39,132,114,165,219,206,162,76,190,14,47,191,176,168,130,104,16,209,148,22,239,196,17,78,237,74,162,219,110,115,148,251,55,25,106,83,153,122,100,223,247,159,53,220,43,147,149,215,88,85,75,39,67,137,206,136,175,103,159,234,136,180,149,222,220,138,67,50,56,213,102,49,200,102,23,64,183,248,107,158,8,74,134,70,213,200,110,175,48,128,137,70,184,169,121,218,181,165,97,23,166,231,252,223,53,94,197,53,84,186,26,224,28,208,30,16,183,43,44,115,187,194,57,110,36,67,53,30,255,152,223,239,160,170,97,227,169,73,142,35,28,135,70,93,103,215,65,163,23,225,120,150,160,228,105,147,68,27,242,148,164,41,121,96,122,0,204,80,124,49,137,83,82,155,180,117,122,16,125,198,121,146,197,22,61,56,41,108,237,85,237,195,207,247,232,136,87,80,68,213,233,191,189,55,187,27,105,60,85,228,253,54,52,152,131,89,43,187,238,44,129,148,59,203,135,118,203,239,120,232,167,164,220,252,5,44,148,7,2,233,46,127,186,202,163,207,98,33,208,54,56,18,61,96,208,178,190,19,210,101,117,18,94,206,57,92,48,49,244,0,8,229,160,102,0,17,193,65,27,242,173,80,57,131,226,147,123,148,32,205,90,254,126,219,238,250,149,166,148,65,7,102,193,210,103,200,250,236,176,5,224,228,97,79,22,113,215,148,245,43,108,22,136,117,89,172,105,85,142,5,1,150,52,32,204,85,30,243,249,239,53,151,33,199,223,68,236,63,248,240,231,27,22,125,38,160,68,43,110,177,47,160,250,161,38,112,112,28,172,83,183,197,98,104,37,250,144,231,169,148,114,177,194,190,41,47,47,133,116,129,49,208,253,223,40,66,191,45,199,10,174,94,110,50,18,249,137,163,114,191,181,204,36,103,230,45,219,193,188,170,71,5,250,86,226,152,41,1,219,210,36,29,79,241,159,247,54,118,112,194,60,166,82,245,222,159,28,106,174,228,54,21,234,249,254,82,136,172,109,26,229,239,202,143,194,200,245,221,114,235,34,2,47,202,247,75,104,208,183,244,3,205,160,119,45,196,240,103,161,238,218,84,102,30,43,182,112,236,82,12,137,230,250,134,60,109,173,185,238,113,168,1,97,188,14,198,184,39,48,49,220,206,1,88,51,187,82,103,10,210,133,131,150,171,200,135,87,108,85,222,172,238,146,245,166,220,230,28,126,6,227,159,198,147,3,20,240,139,128,98,203,4,215,21,77,57,115,225,197,196,213,124,161,76,95,191,215,151,8,13,205,129,230,141,163,94,180,208,163,135,96,241,216,51,210,234,49,234,74,141,120,20,154,96,236,77,194,202,56,237,113,189,49,59,106,15,146,53,229,33,35,100,136,192,127,251,187,26,98,226,4,255,229,112,133,173,35,129,16,153,255,190,202,226,134,182,248,235,168,11,182,95,83,215,26,131,61,49,10,165,120,96,233,147,36,89,27,116,100,186,54,41,233,67,202,212,239,175,13,2,150,188,99,101,224,138,141,8,238,214,117,139,193,112,64,204,24,93,36,248,8,135,163,58,128,19,146,227,151,68,83,225,59,113,130,31,23,169,196,220,3,171,182,62,122,38,90,218,177,30,209,145,151,19,235,37,110,226,196,176,47,249,86,205,199,177,76,252,193,218,84,248,51,43,163,141,72,245,23,231,65,35,84,83,52,142,108,240,238,248,231,66,194,79,76,140,24,140,196,46,49,130,104,88,243,116,36,53,245,165,1,254,116,52,141,139,56,191,119,78,173,62,47,31,61,97,181,71,208,179,206,191,189,107,51,98,54,146,134,198,178,49,203,142,135,209,105,36,244,211,193,176,210,65,201,184,133,84,211,216,131,85,238,5,148,39,127,116,208,61,28,70,164,148,199,70,221,223,39,46,188,74,88,24,238,38,175,27,63,250,194,71,95,244,120,105,110,34,142,11,29,54,180,60,215,225,253,120,28,171,193,82,125,103,80,230,250,155,56,235,22,225,213,122,244,36,254,167,217,164,31,245,65,143,61,90,146,215,12,223,54,96,82,215,56,32,173,69,27,57,246,15,5,122,111,184,235,100,43,42,104,218,52,162,89,207,116,193,91,211,212,224,29,23,221,221,183,208,135,48,7,180,235,52,91,67,49,132,23,160,84,142,76,240,51,165,146,150,213,224,161,205,87,133,180,132,171,193,70,115,3,219,22,160,235,72,165,220,130,223,172,198,89,34,138,29,225,176,219,215,156,204,142,167,58,126,98,163,122,93,239,76,166,158,180,4,53,51,207,108,198,109,138,27,44,149,235,90,35,153,202,55,133,241,127,4,40,87,237,69,88,251,55,134,10,15,131,233,45,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("623e144d-2bff-4944-aa0a-346ec2a0efa2"));
		}

		#endregion

	}

	#endregion

}
