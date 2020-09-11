namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IEsnSecurityEngineSchema

	/// <exclude/>
	public class IEsnSecurityEngineSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IEsnSecurityEngineSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IEsnSecurityEngineSchema(IEsnSecurityEngineSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d9c30106-e300-4bc7-ad30-d1a26877b5c8");
			Name = "IEsnSecurityEngine";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,221,85,77,75,3,49,16,61,183,208,255,48,212,139,130,116,239,126,20,100,93,164,7,69,172,254,128,52,59,221,134,54,201,50,147,173,20,241,191,59,217,221,138,181,85,132,42,20,47,75,242,152,55,239,205,75,216,56,101,145,75,165,17,30,145,72,177,159,134,65,234,221,212,20,21,169,96,188,27,100,227,187,94,247,165,215,237,84,108,92,1,227,21,7,180,231,189,174,32,71,132,133,148,0,140,92,64,154,74,151,51,24,101,236,198,168,43,50,97,149,185,194,56,172,75,147,36,129,11,174,172,85,180,26,182,251,123,242,75,147,35,131,197,48,243,57,195,212,19,232,25,234,121,20,42,145,172,97,142,253,131,7,140,10,37,25,70,96,175,141,90,128,195,240,236,105,46,100,102,85,32,15,214,42,201,7,153,178,154,44,140,6,179,246,183,211,94,39,78,183,229,176,6,210,232,6,158,103,98,16,9,228,3,21,203,98,166,24,148,214,162,28,189,17,106,52,75,140,30,165,235,134,161,109,71,13,82,42,82,22,156,132,127,217,103,25,217,170,167,81,222,31,142,235,229,186,3,8,54,184,72,234,218,221,212,70,49,50,179,13,109,48,155,196,137,247,11,72,149,123,64,149,55,149,183,77,225,241,77,101,114,120,119,112,10,245,126,221,246,228,60,146,247,11,167,244,28,226,113,182,206,14,48,148,148,80,5,252,113,32,191,19,135,246,214,74,215,131,141,35,109,252,253,117,28,152,155,3,189,29,91,196,182,238,170,146,127,21,69,126,123,99,64,213,200,87,113,102,50,225,189,28,250,247,73,182,219,79,26,251,231,155,227,2,255,121,192,215,113,68,220,51,226,215,230,61,67,151,55,79,90,175,43,200,27,106,144,245,144,28,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d9c30106-e300-4bc7-ad30-d1a26877b5c8"));
		}

		#endregion

	}

	#endregion

}

