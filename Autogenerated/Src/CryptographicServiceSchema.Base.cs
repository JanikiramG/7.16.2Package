namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CryptographicServiceSchema

	/// <exclude/>
	public class CryptographicServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CryptographicServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CryptographicServiceSchema(CryptographicServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ba8f2b10-80c4-416c-92db-1fe39960f378");
			Name = "CryptographicService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("55f82158-5486-4bb7-b202-c8f84f805cfa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,84,81,111,218,48,16,126,78,165,254,7,43,125,9,18,50,239,163,173,212,50,54,117,27,109,213,116,235,3,234,131,73,14,26,53,177,189,179,67,151,78,251,239,59,39,14,132,192,24,130,8,223,125,254,190,207,119,231,72,81,128,209,34,1,246,8,136,194,168,165,229,19,37,151,217,170,68,97,51,37,79,79,126,159,158,4,165,201,228,138,197,149,177,80,140,123,235,93,252,94,54,6,92,103,9,204,84,10,249,209,36,127,130,197,113,192,85,98,179,117,79,165,107,187,40,254,149,65,56,20,39,193,237,46,202,207,189,26,29,200,162,72,236,179,139,93,25,125,11,150,96,154,148,23,89,158,217,234,1,126,150,25,66,1,210,154,168,187,112,54,217,5,251,207,22,135,226,62,144,14,156,136,46,23,121,150,176,36,23,198,176,9,86,218,170,21,10,253,146,37,222,17,251,192,174,133,129,118,229,90,18,204,239,52,52,53,239,250,13,230,116,170,27,185,86,175,16,205,192,190,168,148,12,133,247,119,241,99,56,100,215,42,173,98,91,229,206,36,193,102,96,140,88,193,38,202,159,72,84,67,58,116,60,129,115,8,198,126,82,88,8,187,179,161,9,241,47,70,201,33,123,160,249,81,210,192,113,156,59,166,99,29,141,70,236,220,148,69,33,176,186,108,3,103,221,15,235,253,97,157,208,25,251,56,141,249,134,103,212,39,58,215,2,69,193,36,13,245,69,168,169,152,111,10,211,240,114,203,215,145,226,231,163,26,189,221,140,96,75,148,198,195,135,187,182,206,122,203,118,77,52,237,62,71,228,59,105,44,186,81,251,236,166,64,174,1,45,164,247,222,206,15,145,151,16,121,64,235,113,208,180,52,200,150,204,167,248,141,185,45,243,252,14,167,133,182,85,180,1,182,200,160,81,245,74,188,70,141,235,204,159,250,185,22,200,146,122,146,252,208,124,133,138,154,179,115,87,103,66,82,151,144,95,105,29,131,181,196,99,230,225,204,172,190,27,192,214,46,21,124,210,163,9,159,199,199,205,246,117,183,166,157,43,4,163,74,76,32,182,10,73,158,76,57,61,50,38,33,113,174,248,147,194,215,250,157,68,151,100,7,58,222,146,208,29,86,232,199,140,24,36,188,177,111,42,17,121,246,46,22,57,225,157,171,168,167,212,140,117,16,132,135,110,24,221,142,112,143,193,240,254,217,167,191,18,208,117,237,26,109,94,183,51,28,120,107,246,5,213,91,237,198,213,227,1,150,128,32,19,216,236,138,186,190,7,221,126,249,129,40,118,171,223,52,173,95,79,254,168,252,9,61,69,243,98,139,246,122,126,143,106,157,165,128,190,66,253,94,182,233,104,95,117,111,206,14,242,242,169,172,227,219,241,236,28,201,61,232,71,223,191,242,229,208,255,101,6,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateCryptoServiceKeyExceptionMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateCryptoServiceKeyExceptionMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("7264c8f8-6a12-42f2-b6d0-3a6bc04b2a99"),
				Name = "CryptoServiceKeyExceptionMessage",
				CreatedInPackageId = new Guid("55f82158-5486-4bb7-b202-c8f84f805cfa"),
				CreatedInSchemaUId = new Guid("ba8f2b10-80c4-416c-92db-1fe39960f378"),
				ModifiedInSchemaUId = new Guid("ba8f2b10-80c4-416c-92db-1fe39960f378")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ba8f2b10-80c4-416c-92db-1fe39960f378"));
		}

		#endregion

	}

	#endregion

}

