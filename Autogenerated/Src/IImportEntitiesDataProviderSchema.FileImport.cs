namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IImportEntitiesDataProviderSchema

	/// <exclude/>
	public class IImportEntitiesDataProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IImportEntitiesDataProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IImportEntitiesDataProviderSchema(IImportEntitiesDataProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("18959618-7987-4279-b581-a64c3683bed3");
			Name = "IImportEntitiesDataProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,84,75,107,227,48,16,62,55,144,255,48,164,151,44,44,241,189,245,6,54,143,182,161,148,13,77,217,187,108,143,93,81,89,50,35,201,139,41,253,239,59,178,147,166,113,147,144,139,95,243,61,230,27,73,214,162,68,91,137,20,225,5,137,132,53,185,155,204,141,206,101,225,73,56,105,244,228,78,42,92,149,149,33,55,28,188,15,7,87,222,74,93,192,166,177,14,203,219,222,59,83,149,194,52,240,236,228,30,53,146,76,25,195,168,202,39,74,166,32,181,67,202,131,221,170,211,92,106,39,157,68,187,16,78,172,201,212,50,67,98,248,123,75,186,186,38,44,88,11,158,208,189,154,204,222,192,186,149,233,138,81,20,65,108,125,89,10,106,166,187,15,115,133,130,44,100,44,7,57,153,18,102,62,207,145,48,251,98,215,128,19,137,66,72,26,168,58,203,12,226,74,144,40,9,115,208,60,145,95,35,217,194,55,104,45,251,175,178,17,68,159,22,113,212,55,237,200,39,152,211,56,106,203,45,186,54,50,107,123,212,71,250,226,49,140,239,61,3,122,18,63,110,207,4,94,160,66,135,96,212,142,6,184,213,154,92,216,112,46,245,182,139,117,248,202,106,100,239,188,78,79,117,254,71,245,154,126,22,255,194,242,141,3,41,14,1,126,66,95,111,10,167,92,206,134,91,105,139,156,168,23,12,156,129,44,185,52,94,245,105,119,24,232,27,240,13,27,222,190,190,212,199,128,132,206,147,182,92,216,61,133,82,98,140,130,141,168,241,112,32,47,102,49,27,247,195,194,190,17,158,207,82,251,18,41,108,195,184,3,118,214,83,216,119,113,118,50,243,87,76,223,64,212,66,170,118,47,51,13,210,142,199,119,175,221,165,227,217,251,205,3,109,52,125,252,166,116,114,24,207,104,189,114,80,11,37,249,192,225,228,200,112,254,110,107,143,135,54,99,254,17,64,207,122,151,247,26,117,214,157,251,238,29,107,94,120,88,134,235,131,208,153,66,138,151,68,134,158,248,124,136,2,219,194,111,42,120,143,29,59,235,97,117,22,179,150,16,254,86,31,195,193,199,127,134,165,8,254,244,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("18959618-7987-4279-b581-a64c3683bed3"));
		}

		#endregion

	}

	#endregion

}

