namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PassportConstantsSchema

	/// <exclude/>
	public class PassportConstantsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PassportConstantsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PassportConstantsSchema(PassportConstantsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c1419524-889b-4d29-8d12-e03bf9d0efa5");
			Name = "PassportConstants";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,147,219,138,219,48,16,64,159,19,200,63,136,205,75,251,160,141,172,155,37,122,1,203,151,165,47,37,144,253,1,197,150,183,6,91,54,150,221,98,74,255,189,74,182,45,78,119,33,221,38,173,145,197,120,24,196,28,159,209,232,42,251,0,118,147,27,76,243,102,181,92,45,173,110,140,235,116,110,192,189,233,123,237,218,114,184,141,91,91,86,15,99,175,135,170,181,171,229,215,213,114,209,141,251,186,202,129,27,124,46,7,121,173,157,3,91,191,117,109,63,248,114,159,183,131,243,117,135,218,197,102,179,1,111,221,216,52,186,159,222,255,76,172,215,235,195,123,124,192,122,246,53,203,62,134,0,206,11,31,227,219,95,231,110,230,7,159,182,213,27,93,180,182,158,192,221,88,21,96,55,118,93,61,109,245,212,24,59,36,166,214,83,214,183,77,166,243,1,188,3,214,124,57,86,189,186,73,211,40,137,8,146,16,199,105,8,105,64,98,40,20,231,48,149,130,98,138,35,154,96,124,243,250,248,175,174,65,246,15,209,182,181,182,39,104,60,139,153,64,76,66,25,211,8,82,42,2,40,194,144,65,165,162,36,163,17,141,18,22,156,69,123,161,177,75,105,118,190,194,100,149,173,220,39,83,156,138,146,169,34,216,235,81,65,154,64,170,168,130,34,73,164,87,230,65,36,67,33,75,200,245,104,174,11,244,177,29,158,101,82,2,121,152,4,65,66,50,1,41,243,96,81,154,10,136,83,204,9,10,21,162,140,255,217,240,157,119,115,41,200,253,212,153,31,225,9,67,34,184,200,168,242,119,71,82,238,189,168,0,74,191,67,158,41,73,34,230,47,84,74,95,226,101,253,100,168,254,162,243,15,246,115,91,229,102,230,96,116,177,182,185,169,127,51,64,202,189,36,216,104,88,18,190,135,1,13,16,196,92,6,16,161,128,177,2,81,130,17,187,172,251,75,38,233,57,140,173,238,135,74,215,7,47,213,41,11,34,161,164,251,146,65,134,13,135,69,25,120,19,97,176,63,176,20,28,25,73,68,126,126,154,254,135,137,39,157,115,41,10,34,203,226,108,231,139,111,171,165,95,223,1,83,93,218,124,199,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c1419524-889b-4d29-8d12-e03bf9d0efa5"));
		}

		#endregion

	}

	#endregion

}

