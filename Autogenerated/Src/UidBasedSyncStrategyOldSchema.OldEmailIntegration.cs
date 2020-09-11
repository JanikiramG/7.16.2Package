﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UidBasedSyncStrategyOldSchema

	/// <exclude/>
	public class UidBasedSyncStrategyOldSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UidBasedSyncStrategyOldSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UidBasedSyncStrategyOldSchema(UidBasedSyncStrategyOldSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e3afb038-7205-42b8-911f-97b12b196201");
			Name = "UidBasedSyncStrategyOld";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("80eb4b00-d20b-4335-a2cc-1f02c0e63f83");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,88,109,111,219,54,16,254,156,2,253,15,7,23,40,236,65,144,243,161,251,176,188,120,88,221,165,48,144,100,89,156,164,159,25,137,182,137,82,164,74,82,118,189,162,255,125,71,82,178,104,89,178,147,118,45,6,4,73,76,222,61,188,123,238,133,71,11,146,81,157,147,132,194,29,85,138,104,57,51,241,21,97,252,229,139,47,47,95,28,21,154,137,57,76,215,218,208,44,30,75,206,105,98,152,20,58,126,79,5,85,44,57,109,202,92,50,241,169,94,180,64,111,41,141,39,25,201,237,255,245,78,125,216,88,102,153,20,184,131,123,175,20,157,35,60,140,57,209,250,4,238,89,250,150,104,154,78,215,34,153,26,69,12,157,175,157,220,112,56,132,51,93,100,25,81,235,209,230,51,165,144,40,58,59,239,77,66,133,222,112,4,44,203,57,205,168,48,196,48,35,69,4,41,229,108,73,21,77,97,166,100,22,234,190,67,37,127,40,138,79,153,72,104,3,44,174,206,27,54,13,80,20,63,126,212,213,231,54,235,161,192,5,48,18,52,181,84,2,225,28,4,93,1,198,64,147,57,213,81,169,251,136,60,8,97,137,34,40,4,58,167,9,155,49,84,45,4,251,84,80,96,41,90,103,87,84,165,26,131,154,37,111,126,125,243,27,44,140,201,245,201,112,104,164,228,58,102,212,204,98,169,230,195,133,201,248,176,148,217,184,16,152,156,23,143,156,37,144,19,101,24,225,144,216,16,180,251,112,2,251,73,66,176,47,46,76,155,120,94,81,179,144,41,70,244,70,177,37,202,248,221,102,20,221,194,165,36,169,6,33,13,104,132,92,40,41,216,63,232,119,69,16,48,145,210,207,248,119,38,85,86,178,104,163,40,121,74,85,92,129,76,183,215,33,43,180,65,78,3,30,153,128,51,116,149,100,24,116,16,88,3,231,189,132,51,244,6,35,28,129,207,209,48,163,48,129,199,110,63,246,216,23,14,248,66,42,235,184,51,146,216,194,176,201,150,57,103,55,182,188,195,112,97,192,25,34,64,174,164,145,137,228,160,40,225,165,74,132,94,16,149,44,74,61,88,49,179,128,222,253,36,133,235,147,95,122,128,209,86,107,155,39,43,178,214,168,103,10,37,52,96,112,76,197,137,167,196,122,212,96,225,106,107,223,225,6,46,141,11,165,208,159,82,8,3,61,17,222,41,235,131,61,126,197,48,57,45,105,31,89,158,211,218,161,201,12,18,175,91,209,187,34,214,178,76,46,145,88,34,82,123,0,177,236,147,57,65,171,240,39,195,218,127,148,159,163,32,166,206,119,208,85,78,185,195,176,56,92,53,148,176,222,117,20,193,96,108,78,223,42,59,191,226,226,184,29,196,81,35,118,174,9,8,109,8,166,106,124,54,116,26,53,64,201,106,168,84,210,50,177,212,213,125,175,1,83,233,89,160,220,103,54,180,43,194,123,106,174,165,177,201,66,211,80,132,234,190,181,15,188,221,3,176,77,247,232,168,3,36,107,95,62,183,232,247,194,114,123,165,231,141,221,126,137,124,234,128,217,12,250,19,237,227,252,129,232,91,90,134,170,223,14,61,168,12,58,234,204,22,60,189,119,220,243,232,71,223,111,224,87,247,251,146,105,115,198,165,152,143,182,124,182,203,8,214,126,74,60,38,149,82,127,16,223,73,43,220,47,81,155,32,241,84,170,205,166,229,100,71,96,44,11,204,239,17,28,195,235,215,59,54,196,23,76,89,112,60,101,234,178,179,63,128,243,115,232,228,104,195,98,135,229,183,174,118,254,48,253,227,45,22,124,122,117,184,235,4,191,238,105,164,31,22,180,234,8,221,197,25,1,51,186,110,174,247,19,13,137,245,28,117,18,142,109,73,71,78,7,51,94,161,156,187,43,143,255,7,157,237,110,65,9,94,0,52,130,149,245,178,69,199,158,194,16,13,23,193,88,153,167,118,190,37,225,5,226,86,39,173,40,224,61,88,100,232,233,130,52,26,94,201,228,83,91,83,123,28,123,207,238,58,93,205,43,25,221,169,130,158,13,19,148,158,181,90,186,213,138,81,126,70,184,246,10,18,57,82,43,166,187,186,218,35,206,18,208,218,56,158,213,170,170,66,248,169,245,221,82,70,79,47,113,56,3,123,100,124,131,181,64,251,221,21,30,150,227,43,42,82,63,248,116,78,65,210,184,249,100,79,249,98,199,212,56,237,29,24,130,108,65,218,136,98,165,169,101,80,32,63,242,150,188,127,174,81,205,148,42,157,135,37,83,166,192,81,179,251,202,236,188,51,90,238,204,50,204,73,53,165,217,206,211,55,202,22,115,136,228,55,254,182,189,167,63,136,64,20,156,15,14,246,82,23,140,30,198,251,1,155,91,202,204,186,103,27,94,78,149,89,239,60,32,118,136,252,25,49,105,183,237,32,243,126,182,178,238,213,3,110,128,116,152,230,64,56,184,12,15,242,121,91,54,251,176,245,53,158,138,113,119,47,196,206,95,63,152,176,187,105,201,221,229,86,63,27,108,101,249,147,90,230,124,223,25,111,136,89,120,48,119,179,248,235,114,191,168,69,207,241,54,160,105,84,193,227,196,170,155,193,15,73,177,106,104,215,246,188,252,29,25,177,195,210,225,20,9,17,3,127,70,46,182,229,45,49,195,42,64,215,204,162,59,195,170,133,235,13,197,117,229,127,83,24,3,22,190,169,61,76,236,148,34,8,223,20,55,14,214,101,163,216,30,170,163,42,205,107,239,241,146,113,133,95,230,116,181,207,56,66,226,17,69,38,74,169,90,37,158,232,107,84,249,75,253,153,229,88,25,3,248,221,141,50,117,209,157,64,239,162,166,247,52,4,78,28,228,133,131,127,176,243,197,33,228,206,130,172,106,241,36,208,247,71,237,27,208,109,251,218,221,232,187,55,59,53,6,77,212,49,190,204,109,38,122,239,31,252,16,212,36,36,242,83,236,209,142,63,219,55,237,158,183,78,56,235,63,249,182,116,95,76,236,233,38,93,223,252,196,221,169,49,192,4,108,175,194,242,107,16,28,151,149,98,233,190,247,220,254,172,107,244,203,253,217,218,66,203,127,229,105,149,253,63,222,227,150,58,251,6,18,162,80,189,43,79,202,181,112,9,87,254,5,39,211,221,49,203,20,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e3afb038-7205-42b8-911f-97b12b196201"));
		}

		#endregion

	}

	#endregion

}

