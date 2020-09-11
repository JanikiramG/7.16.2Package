namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseServiceRequestSchema

	/// <exclude/>
	public class BaseServiceRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseServiceRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseServiceRequestSchema(BaseServiceRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("56f508aa-2354-4a52-b001-b51958e64e5c");
			Name = "BaseServiceRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,145,193,78,195,48,16,68,207,141,148,127,88,149,11,92,156,59,41,72,37,32,132,80,81,212,244,134,56,56,233,38,88,36,113,88,175,43,133,138,127,199,113,218,0,85,79,214,142,231,217,51,218,86,54,104,58,89,32,108,144,72,26,93,178,72,116,91,170,202,146,100,165,91,145,60,100,43,189,197,218,132,193,62,12,194,96,102,141,106,43,200,122,195,216,136,181,109,89,53,40,50,36,37,107,245,229,153,216,251,46,8,43,55,64,82,75,99,174,225,78,26,116,174,157,42,112,141,159,22,13,123,87,20,69,176,48,182,105,36,245,183,135,217,19,160,75,200,29,3,52,186,129,53,184,44,226,200,68,127,160,215,123,201,210,197,102,146,5,191,57,161,179,121,173,10,40,252,67,231,126,158,141,93,166,144,41,233,14,137,21,186,164,169,135,199,251,211,120,94,120,68,118,241,8,204,112,242,59,194,50,125,130,15,236,197,68,68,167,200,98,39,107,139,211,184,57,11,253,122,124,161,21,54,57,210,229,139,91,17,220,192,220,121,231,87,67,185,99,59,195,52,108,98,217,169,103,236,97,15,21,114,60,100,138,225,251,80,14,219,237,216,207,207,163,250,95,116,218,15,139,10,188,174,3,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("56f508aa-2354-4a52-b001-b51958e64e5c"));
		}

		#endregion

	}

	#endregion

}

