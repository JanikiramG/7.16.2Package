﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EntityUtilsServiceSchema

	/// <exclude/>
	public class EntityUtilsServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EntityUtilsServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EntityUtilsServiceSchema(EntityUtilsServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3840c26f-96f8-4ffa-af38-ec8670359a54");
			Name = "EntityUtilsService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("eef46199-fd2a-476e-ade8-8bc800e7efdf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,213,86,77,111,227,54,16,61,123,129,253,15,3,247,162,0,134,124,79,28,3,73,218,164,110,155,77,176,78,186,135,96,15,180,52,182,217,72,164,74,82,9,212,69,254,123,103,72,73,150,229,143,13,176,167,61,217,34,103,222,204,60,206,60,82,137,28,109,33,18,132,7,52,70,88,189,116,241,149,86,75,185,42,141,112,82,171,143,31,190,125,252,48,40,173,84,43,152,87,214,97,126,214,251,38,251,44,195,132,141,109,124,131,10,141,76,118,108,230,104,94,100,130,183,58,197,236,232,102,124,65,72,47,62,244,113,187,47,184,216,24,116,147,55,24,255,166,156,116,18,237,65,131,107,145,56,109,14,88,16,50,89,229,185,207,128,246,127,49,184,162,116,224,42,19,214,158,130,7,175,30,157,204,108,157,144,183,26,143,199,48,177,101,158,11,83,77,235,111,54,34,91,176,193,14,18,70,128,165,54,240,170,205,51,71,125,149,110,77,110,72,123,6,151,231,195,0,62,28,79,227,6,114,220,193,124,170,3,210,9,57,67,37,124,229,181,11,91,124,66,71,9,23,196,218,194,7,252,140,255,150,210,96,142,202,217,168,251,193,212,193,57,124,199,133,173,226,122,33,61,225,32,69,185,200,100,82,231,191,75,0,156,194,165,176,216,210,49,248,230,41,105,153,187,69,183,214,41,113,119,111,248,108,3,97,59,140,249,133,153,162,147,19,153,252,15,45,8,80,248,10,82,89,39,20,5,209,75,112,107,220,101,171,155,9,49,23,178,140,219,8,227,126,136,137,65,87,26,101,167,23,63,130,63,25,55,48,140,91,132,194,186,220,252,142,89,129,6,110,208,237,44,70,39,192,83,53,24,4,136,208,89,161,39,43,26,33,55,217,241,152,70,156,42,157,187,117,166,100,187,11,179,42,249,176,162,97,73,221,69,27,42,140,224,112,4,143,91,11,39,39,220,227,131,183,250,68,80,165,225,80,14,157,144,63,233,35,7,116,165,11,201,103,163,82,200,164,122,182,144,10,39,192,105,207,157,45,48,145,75,137,41,160,175,0,38,133,48,34,39,50,65,145,210,156,15,13,237,147,191,170,57,153,165,76,232,210,232,60,184,235,210,248,254,9,161,123,190,97,183,227,120,236,140,189,239,126,199,233,67,27,10,100,58,130,215,181,76,214,144,232,162,10,181,72,235,43,163,34,120,58,233,160,61,214,126,232,221,122,60,122,187,220,9,224,177,95,101,150,193,2,155,0,78,31,135,79,116,86,230,234,19,253,15,184,225,219,111,122,25,97,152,70,70,222,67,219,60,89,99,46,24,207,50,127,71,99,99,207,99,56,13,24,33,58,13,75,77,33,119,66,91,239,113,200,67,169,76,255,146,214,49,100,221,53,214,239,121,39,59,10,237,177,135,195,132,59,49,61,30,81,42,162,8,103,105,39,134,76,131,4,135,45,16,206,137,100,237,117,239,59,80,246,78,101,213,204,123,13,167,215,153,88,81,207,10,199,88,9,13,4,77,128,111,33,77,70,239,194,110,228,35,244,139,45,51,159,29,99,208,137,246,228,229,233,142,52,192,95,138,93,233,31,60,209,85,53,83,47,250,25,163,48,192,164,237,195,251,187,249,3,169,192,165,78,171,185,171,50,214,123,50,187,69,107,197,10,219,213,248,139,17,69,129,233,200,235,16,139,61,90,119,173,77,78,21,117,29,194,82,252,135,213,106,4,159,233,173,64,18,132,199,237,252,141,209,92,25,191,74,175,66,52,155,19,146,46,170,108,4,225,119,202,74,82,53,55,117,116,83,202,20,182,7,117,4,126,113,103,196,26,4,216,76,71,168,162,94,238,55,238,8,248,232,39,77,216,3,77,88,91,233,197,63,164,155,83,104,27,135,170,84,101,150,141,192,135,88,104,157,65,183,19,104,123,41,50,139,141,162,15,118,111,128,117,248,57,63,112,21,156,5,191,35,68,229,116,82,244,39,36,19,208,98,38,47,234,243,181,135,170,62,71,131,193,46,61,7,25,105,73,24,109,213,220,164,92,223,94,155,244,186,55,205,222,203,131,24,176,94,233,107,33,163,247,199,218,194,162,130,28,157,184,167,15,120,17,25,117,226,123,149,61,192,220,214,206,118,75,36,25,50,4,56,60,123,27,210,89,165,209,32,60,99,197,23,64,7,195,167,69,122,177,173,77,37,11,187,79,182,99,94,108,153,54,209,58,106,246,243,143,245,83,200,255,20,106,131,123,38,22,29,53,50,247,12,39,26,184,8,231,241,94,41,184,225,215,104,235,118,161,210,208,140,190,13,163,142,223,141,167,189,59,206,83,232,245,64,51,136,47,194,176,172,250,194,120,134,233,249,116,56,129,102,10,187,51,112,43,20,213,103,182,228,164,89,59,239,61,178,226,61,142,1,145,110,7,164,59,0,162,63,177,250,155,219,229,94,72,179,183,142,231,142,1,77,222,161,186,6,94,20,187,73,61,206,184,65,186,238,49,5,59,235,202,81,48,220,242,34,151,61,149,241,235,115,86,63,136,47,43,66,142,122,145,54,179,31,168,125,234,237,199,15,122,238,43,138,78,190,246,66,196,124,156,181,251,150,34,55,83,102,251,101,248,127,181,71,75,100,173,242,237,104,202,205,152,110,72,26,108,93,17,222,174,151,12,21,26,254,109,26,239,178,106,216,142,26,196,166,220,77,189,205,14,87,183,65,175,205,222,252,207,91,247,109,223,56,30,121,133,135,213,237,69,90,251,31,121,14,108,32,156,15,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3840c26f-96f8-4ffa-af38-ec8670359a54"));
		}

		#endregion

	}

	#endregion

}
