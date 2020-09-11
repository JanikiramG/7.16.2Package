namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OpportunityManagementUtilsSchema

	/// <exclude/>
	public class OpportunityManagementUtilsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OpportunityManagementUtilsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OpportunityManagementUtilsSchema(OpportunityManagementUtilsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4fcdad74-69f0-4516-b611-2a2e42ad8a52");
			Name = "OpportunityManagementUtils";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f3263ef9-3aa8-474b-9e91-a704f3bef247");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,144,193,106,195,48,12,134,207,9,228,29,124,108,97,248,5,118,106,183,50,10,107,7,203,122,26,59,184,142,154,25,98,57,147,228,67,24,125,247,201,43,27,11,235,193,6,139,95,159,62,11,93,4,30,157,7,243,2,68,142,211,73,236,93,194,83,232,51,57,9,9,237,211,56,38,146,140,65,166,157,67,215,67,4,148,166,254,108,234,42,115,192,126,214,72,112,251,91,111,39,22,136,246,49,224,135,22,181,60,230,227,16,188,241,131,99,54,87,177,7,9,3,155,130,254,9,179,168,133,55,199,148,6,243,0,178,229,21,78,173,127,135,232,86,93,12,24,88,84,19,186,245,244,12,62,81,199,139,3,3,233,7,16,124,177,55,121,246,188,41,228,106,116,228,34,43,154,84,243,245,205,232,96,181,184,80,247,101,31,203,139,66,85,17,72,38,252,31,176,106,177,152,163,237,253,186,5,159,73,131,27,236,3,130,253,214,221,252,105,189,110,188,44,27,171,206,122,149,211,212,231,47,251,190,207,216,147,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4fcdad74-69f0-4516-b611-2a2e42ad8a52"));
		}

		#endregion

	}

	#endregion

}

