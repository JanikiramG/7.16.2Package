﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FlagBasedSinceDateSyncStrategySchema

	/// <exclude/>
	public class FlagBasedSinceDateSyncStrategySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FlagBasedSinceDateSyncStrategySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FlagBasedSinceDateSyncStrategySchema(FlagBasedSinceDateSyncStrategySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("74e8dfd3-1801-4c2c-9fa2-a4e7d882685a");
			Name = "FlagBasedSinceDateSyncStrategy";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0bd8020-de17-4815-83cd-c2dac7bbc324");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,85,109,111,211,48,16,254,220,73,251,15,71,145,166,68,10,41,124,221,232,36,214,151,105,64,7,44,45,8,33,52,185,201,181,179,150,216,145,237,20,66,213,255,206,57,47,77,27,214,78,124,105,108,223,221,115,247,220,61,118,5,75,80,167,44,68,152,162,82,76,203,133,241,39,140,199,167,39,235,211,147,78,166,185,88,66,144,107,131,201,69,107,239,95,199,114,206,98,254,135,25,46,69,99,109,112,6,50,73,14,89,20,30,58,247,71,194,112,195,81,31,116,24,179,208,72,85,122,144,207,75,133,75,170,0,6,49,211,250,28,198,49,91,94,49,141,81,192,69,136,67,102,48,200,69,24,24,69,171,101,94,68,244,122,61,120,171,179,36,97,42,191,220,238,17,33,84,184,232,119,111,118,3,186,189,75,224,73,26,99,130,194,48,110,164,240,32,194,152,175,80,97,4,11,37,147,221,208,38,249,62,132,95,103,233,181,211,42,164,237,163,174,247,199,171,135,140,44,96,36,104,140,49,52,192,226,24,132,52,175,34,197,22,198,43,151,100,49,228,68,99,213,108,137,218,171,128,201,6,54,19,153,230,249,179,37,251,118,99,45,150,254,35,230,191,164,138,42,32,109,11,219,5,176,69,254,11,112,175,107,2,123,244,119,232,254,24,226,130,101,177,185,226,34,162,41,59,38,79,81,46,156,189,238,187,30,220,146,66,161,15,221,227,157,233,186,63,9,50,205,230,49,15,33,180,74,120,174,149,187,74,217,19,72,103,93,136,164,209,149,20,218,48,97,72,91,159,21,95,145,87,105,111,171,168,56,8,144,169,240,1,240,119,170,104,0,54,156,174,74,26,83,144,191,141,217,213,64,39,45,33,33,180,89,64,27,101,5,127,175,11,152,47,25,170,124,154,198,150,254,236,118,120,247,110,60,5,250,142,62,142,166,163,33,173,62,140,190,127,251,116,55,132,245,235,13,4,55,183,131,17,172,223,108,186,23,85,249,40,162,146,193,19,116,84,102,175,144,101,84,116,172,244,168,186,119,188,111,206,76,163,34,12,65,250,179,112,217,222,214,131,226,246,230,160,109,8,26,67,108,180,11,231,22,190,51,39,80,103,223,223,133,117,97,106,129,246,91,176,23,133,83,176,131,73,46,187,41,10,135,205,113,226,19,52,15,50,106,113,222,27,226,161,55,192,191,70,51,19,54,223,68,47,131,102,52,164,236,214,48,203,14,74,122,28,20,143,176,30,231,129,112,167,102,191,98,10,182,215,133,152,145,127,145,190,62,114,220,178,1,124,1,78,227,247,162,15,246,59,229,9,206,12,143,139,55,211,127,207,86,76,135,138,167,102,194,69,109,134,179,51,120,50,206,39,167,175,44,206,176,174,164,163,208,100,74,216,10,198,244,47,96,137,180,106,222,226,84,53,109,138,223,42,204,78,248,80,179,42,18,155,255,236,251,129,50,106,6,238,127,204,224,25,168,166,69,117,55,42,86,37,130,63,150,42,97,198,105,221,77,143,46,107,245,86,122,13,130,63,149,65,17,229,220,243,132,165,246,168,12,247,202,54,15,232,221,203,20,222,136,133,244,111,4,205,159,211,3,83,29,186,238,33,53,87,103,251,2,223,252,5,81,63,196,196,195,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("74e8dfd3-1801-4c2c-9fa2-a4e7d882685a"));
		}

		#endregion

	}

	#endregion

}

