namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SyncStrategyOldSchema

	/// <exclude/>
	public class SyncStrategyOldSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SyncStrategyOldSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SyncStrategyOldSchema(SyncStrategyOldSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cf2c9b7c-7448-46bf-b658-0cce8422cf47");
			Name = "SyncStrategyOld";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("80eb4b00-d20b-4335-a2cc-1f02c0e63f83");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,147,193,78,195,48,12,134,207,157,196,59,88,219,101,149,166,246,62,198,14,236,128,122,168,52,84,120,0,47,245,218,72,105,82,37,233,68,153,246,238,36,109,7,20,134,0,9,110,205,239,216,254,126,59,149,88,145,169,145,17,60,144,214,104,212,222,70,41,114,113,53,57,94,77,130,198,112,89,128,63,223,18,69,73,133,181,255,190,254,20,73,121,69,78,117,250,76,83,193,149,132,141,64,99,150,144,181,146,101,86,163,165,162,237,226,113,28,195,202,52,85,133,186,93,175,12,17,48,77,251,155,105,242,254,230,52,94,3,175,106,65,21,73,139,220,42,25,173,226,115,146,43,82,55,59,193,25,224,206,184,4,102,161,70,109,57,10,96,190,233,168,39,44,33,25,51,4,199,142,227,21,52,37,91,170,220,161,110,187,162,125,240,71,148,209,29,217,71,105,156,66,121,106,138,68,230,244,68,102,238,167,20,58,7,35,226,51,242,129,107,219,56,210,148,140,193,130,186,156,141,18,130,152,245,48,95,87,116,222,184,27,70,8,126,45,65,160,201,54,90,14,98,148,17,106,86,206,173,110,104,241,86,195,85,232,3,247,13,233,118,30,46,64,54,66,132,126,123,193,233,111,124,46,192,109,192,61,132,127,243,123,110,0,123,37,114,210,91,180,229,135,17,92,46,49,76,235,247,94,51,178,3,171,151,75,173,36,127,166,252,59,123,7,197,115,184,156,58,118,227,127,152,225,18,148,132,206,210,96,103,128,156,145,204,251,135,217,157,123,117,44,158,94,0,15,167,236,67,179,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cf2c9b7c-7448-46bf-b658-0cce8422cf47"));
		}

		#endregion

	}

	#endregion

}

