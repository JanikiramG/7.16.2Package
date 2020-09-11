namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EsnCenterFactorySchema

	/// <exclude/>
	public class EsnCenterFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EsnCenterFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EsnCenterFactorySchema(EsnCenterFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("04389b5a-20dc-4773-ad27-ab521c1b58a1");
			Name = "EsnCenterFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,147,77,79,194,64,16,134,207,144,240,31,54,112,105,19,210,222,1,73,180,162,49,17,99,68,79,198,195,218,78,203,198,50,75,246,67,67,140,255,221,105,87,144,45,16,224,56,179,239,60,51,243,78,139,124,1,122,201,83,96,207,160,20,215,50,55,81,34,49,23,133,85,220,8,137,209,100,246,208,105,127,119,218,45,171,5,22,44,145,10,134,94,20,221,240,212,72,37,64,83,158,94,122,10,10,42,100,44,41,185,214,3,54,209,152,0,26,80,78,183,170,69,113,28,179,145,192,57,40,97,50,153,178,120,76,201,215,107,200,185,45,205,149,192,140,232,129,89,45,65,230,193,93,147,16,134,111,164,94,218,247,82,164,44,173,186,236,52,97,3,182,83,70,53,213,30,155,1,167,96,230,50,163,9,31,107,82,61,215,254,193,214,189,254,145,44,81,192,13,108,226,224,69,131,34,227,16,210,202,53,102,189,48,100,117,227,214,39,87,141,151,75,85,216,5,17,216,5,67,248,34,63,81,27,101,171,113,215,47,65,215,175,232,246,155,240,225,134,93,138,15,120,130,165,212,162,246,224,194,157,224,111,253,232,22,204,168,218,224,222,83,141,131,253,19,109,97,65,227,20,180,230,5,149,241,140,150,63,0,246,68,103,114,179,154,117,148,236,100,167,177,103,144,90,186,226,106,130,133,64,56,132,246,85,71,200,10,140,85,184,31,228,62,132,113,80,11,91,7,175,9,205,3,208,65,253,187,133,253,227,8,207,106,34,52,83,103,49,156,169,13,138,75,158,194,241,29,116,24,63,23,58,251,126,220,47,214,3,204,220,47,72,145,203,109,167,40,243,11,137,73,150,94,150,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("04389b5a-20dc-4773-ad27-ab521c1b58a1"));
		}

		#endregion

	}

	#endregion

}

