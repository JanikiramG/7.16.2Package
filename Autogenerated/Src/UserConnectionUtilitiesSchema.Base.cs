﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UserConnectionUtilitiesSchema

	/// <exclude/>
	public class UserConnectionUtilitiesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UserConnectionUtilitiesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UserConnectionUtilitiesSchema(UserConnectionUtilitiesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9a4630a0-0715-4eb0-a130-035289f090c8");
			Name = "UserConnectionUtilities";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fa2eb5ad-958f-4492-adde-c5914e708d28");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,88,77,79,27,49,16,61,7,137,255,48,10,23,42,165,155,59,36,123,73,37,4,18,45,45,32,206,102,119,54,49,108,236,213,216,14,77,17,255,189,227,245,238,102,243,85,4,162,45,2,14,17,241,120,62,158,223,60,59,54,187,59,74,76,209,20,34,65,184,64,34,97,116,102,163,145,86,153,28,59,18,86,106,181,187,115,191,187,211,113,70,170,49,156,207,141,197,41,207,231,57,38,126,210,68,71,168,144,100,114,216,248,140,52,97,116,158,76,48,117,57,210,194,222,78,79,200,118,158,217,35,28,115,22,24,229,194,152,3,184,52,72,92,91,133,220,151,86,230,210,74,52,165,107,191,223,135,129,113,211,169,160,121,92,141,217,215,10,169,12,56,14,132,164,137,4,87,134,206,97,138,118,162,83,19,213,241,253,86,130,194,93,231,50,1,99,121,149,9,36,30,193,118,0,157,251,18,68,3,248,52,36,62,128,179,50,75,152,92,133,88,26,126,56,198,87,144,78,144,243,75,5,137,35,66,101,225,78,211,109,224,61,208,83,219,195,82,8,83,30,72,145,151,216,215,193,7,75,33,72,76,193,119,112,216,53,218,81,130,221,248,114,153,138,104,208,47,189,54,7,85,184,190,242,160,27,159,85,32,253,212,35,97,254,59,90,36,179,136,90,216,214,99,9,25,247,173,137,191,59,65,246,23,220,232,107,24,147,118,5,72,3,118,130,13,61,62,187,199,158,8,139,138,63,41,220,73,59,169,91,100,92,150,201,159,13,31,39,156,165,12,224,36,194,89,253,121,236,149,232,163,24,64,93,209,59,47,55,122,166,101,234,155,82,225,222,183,19,185,218,119,8,92,246,56,132,124,107,90,44,245,124,194,78,231,248,139,44,61,185,27,131,224,212,3,125,125,195,225,113,139,136,79,112,95,186,207,4,249,53,135,93,5,67,56,66,123,82,15,247,219,201,171,194,209,85,173,141,168,85,179,154,27,5,157,120,196,97,182,93,240,176,116,229,213,93,144,28,143,145,184,204,126,83,57,204,62,188,3,173,190,29,189,213,18,106,37,168,157,151,132,163,92,158,255,253,254,130,80,169,143,159,201,212,187,133,246,16,102,85,135,116,81,254,36,116,251,49,100,154,128,156,82,222,141,233,127,45,194,104,135,77,165,201,36,225,177,98,214,93,89,166,27,87,219,6,10,205,29,156,191,236,33,216,142,173,153,138,125,117,161,152,120,157,149,202,28,24,68,207,120,54,236,178,222,190,45,8,125,39,199,43,171,210,194,122,103,158,116,236,246,96,65,29,84,76,191,236,81,252,132,179,184,41,22,181,64,13,107,88,205,121,93,223,151,150,14,236,222,6,38,222,207,33,254,63,247,234,199,142,122,45,23,153,143,141,241,226,27,227,237,139,251,31,233,117,113,233,122,190,82,247,80,165,225,77,185,237,129,73,114,198,52,134,217,34,12,106,246,154,197,44,175,108,19,81,149,173,209,250,146,213,43,253,217,175,27,66,235,72,129,194,59,216,66,238,74,209,166,218,218,134,127,216,184,202,90,35,109,130,23,43,111,81,253,103,49,4,185,115,96,181,63,78,133,18,252,39,170,175,96,209,179,123,184,5,111,235,13,182,1,238,83,96,61,250,154,91,81,81,105,245,255,94,89,50,63,252,6,28,252,147,8,237,17,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9a4630a0-0715-4eb0-a130-035289f090c8"));
		}

		#endregion

	}

	#endregion

}
