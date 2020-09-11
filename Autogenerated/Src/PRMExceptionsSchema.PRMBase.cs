namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PRMExceptionsSchema

	/// <exclude/>
	public class PRMExceptionsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PRMExceptionsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PRMExceptionsSchema(PRMExceptionsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4ed693a9-5407-4385-87e0-d7a39b259ee3");
			Name = "PRMExceptions";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("83b9dda3-84f4-4c2e-b329-54cd69be3f63");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,146,79,111,194,48,12,197,207,32,241,29,172,238,2,210,212,222,25,112,97,76,154,180,13,196,208,238,38,117,33,82,155,84,113,34,198,208,190,251,220,63,48,96,98,199,188,60,255,242,108,199,96,65,92,162,34,88,145,115,200,54,243,241,212,154,76,111,130,67,175,173,137,23,203,215,94,247,208,235,118,2,107,179,185,176,21,133,53,15,189,174,220,221,57,218,136,25,166,57,50,15,225,41,152,116,181,47,233,49,148,185,86,232,105,246,169,168,172,112,181,59,73,18,24,113,40,10,116,251,73,123,158,43,21,28,195,110,75,6,2,147,3,239,52,49,120,11,152,166,144,9,16,118,218,111,193,11,86,92,90,109,97,139,12,152,59,194,116,95,153,40,141,143,236,228,12,94,134,181,100,0,85,37,251,39,24,12,225,45,228,249,220,205,138,210,239,207,242,118,14,117,230,223,22,173,97,239,130,242,214,73,167,139,154,222,56,174,219,170,133,169,228,243,210,136,150,42,52,50,103,155,53,61,140,152,8,148,163,108,28,221,78,21,37,147,248,132,78,174,217,163,18,29,22,96,100,135,227,136,37,16,110,40,154,44,137,109,112,242,82,171,196,163,164,246,213,101,237,52,110,191,216,127,62,214,191,55,229,71,204,64,38,180,70,166,126,133,233,24,218,193,139,85,152,235,47,92,231,226,117,242,57,250,173,245,30,34,249,53,39,36,71,34,252,49,115,124,59,68,252,129,121,160,104,48,128,234,227,117,190,219,13,144,73,155,37,212,231,70,189,20,69,251,1,16,130,20,142,210,2,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateFundTypeDuplicateExceptionLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateFundTypeDuplicateExceptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("28e5b2ac-8529-4669-a3f6-90792e6f311c"),
				Name = "FundTypeDuplicateException",
				CreatedInPackageId = new Guid("83b9dda3-84f4-4c2e-b329-54cd69be3f63"),
				CreatedInSchemaUId = new Guid("4ed693a9-5407-4385-87e0-d7a39b259ee3"),
				ModifiedInSchemaUId = new Guid("4ed693a9-5407-4385-87e0-d7a39b259ee3")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4ed693a9-5407-4385-87e0-d7a39b259ee3"));
		}

		#endregion

	}

	#endregion

}

