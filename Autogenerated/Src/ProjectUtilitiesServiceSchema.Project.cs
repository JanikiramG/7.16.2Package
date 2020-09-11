namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ProjectUtilitiesServiceSchema

	/// <exclude/>
	public class ProjectUtilitiesServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ProjectUtilitiesServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ProjectUtilitiesServiceSchema(ProjectUtilitiesServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9b47c1bf-4868-454f-a509-c1a14ee81229");
			Name = "ProjectUtilitiesService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c746724b-ad7f-4327-918b-435a466c9305");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,85,223,79,219,48,16,126,14,18,255,195,169,123,73,37,148,190,15,90,9,216,64,76,43,155,40,140,135,106,154,220,228,90,60,18,59,179,29,88,64,253,223,119,182,147,38,109,19,216,75,36,219,223,253,250,238,187,139,96,25,234,156,197,8,183,168,20,211,114,105,162,115,41,150,124,85,40,102,184,20,135,7,175,135,7,65,161,185,88,193,172,212,6,179,227,157,115,116,83,8,195,51,140,102,168,56,75,249,139,179,219,67,209,235,19,143,113,42,19,76,223,124,140,78,99,195,159,222,119,18,221,227,162,1,180,211,87,24,93,176,216,72,197,81,119,33,200,144,80,89,230,2,208,251,7,133,43,138,6,231,41,211,250,35,156,203,188,252,174,228,111,140,205,13,145,35,133,70,7,27,141,70,112,162,139,44,99,170,156,84,103,139,5,153,163,39,11,84,133,135,216,186,138,106,163,81,203,42,47,22,41,143,61,160,43,20,216,4,90,13,168,74,110,50,9,108,67,246,146,241,217,40,100,6,19,200,189,75,224,9,82,107,150,28,213,198,164,157,74,48,255,196,12,155,98,182,64,21,94,147,18,96,12,131,202,71,149,213,85,50,24,254,180,208,42,237,203,130,39,176,11,129,87,88,161,57,6,109,63,107,66,175,61,173,40,18,207,108,23,203,149,245,157,225,41,55,212,168,170,206,134,105,46,30,72,80,38,145,49,140,38,61,244,87,70,240,204,205,3,20,181,43,200,208,60,200,68,195,82,170,58,14,88,38,76,217,217,146,121,229,134,120,55,138,132,99,11,158,159,234,252,26,13,201,36,167,54,44,172,231,242,6,255,20,92,97,70,174,116,216,62,88,61,18,119,239,152,88,84,84,93,36,142,213,45,45,244,16,66,122,56,99,26,55,244,248,246,215,100,94,112,76,19,199,166,29,25,207,94,144,251,3,169,145,37,82,164,37,124,101,47,229,73,229,223,74,110,202,4,91,161,154,192,175,184,57,249,89,216,237,90,211,54,82,159,81,133,29,43,27,207,101,238,17,221,82,108,224,81,183,248,170,226,123,202,14,135,224,10,13,218,41,18,199,2,159,123,203,9,157,65,64,166,227,137,151,153,95,3,101,116,137,230,13,131,192,58,109,37,124,170,86,133,237,88,56,40,52,42,122,16,100,71,28,12,142,224,110,235,98,56,28,218,253,82,233,189,151,186,169,151,227,127,177,70,235,164,158,94,39,106,150,166,160,139,133,84,9,23,182,167,207,82,61,234,30,70,221,77,206,20,203,64,208,52,143,7,249,102,136,39,223,247,86,194,201,200,65,253,34,248,86,175,176,246,12,4,115,218,148,87,226,73,62,98,120,167,248,45,102,121,106,115,176,91,162,89,92,247,148,230,204,49,87,40,36,138,234,77,117,33,85,198,12,129,201,201,20,181,38,198,253,85,244,69,75,113,228,168,63,147,73,57,51,101,138,91,176,205,109,116,175,88,158,99,98,135,6,181,217,218,68,93,171,179,47,171,208,173,173,13,27,181,180,186,92,108,54,184,151,90,23,196,27,7,179,34,142,41,95,2,82,24,116,119,107,167,134,192,168,178,6,213,238,162,189,157,57,222,26,190,232,7,75,11,66,245,21,208,228,238,67,172,33,102,38,126,128,240,243,223,24,115,247,239,193,225,94,208,38,197,37,75,53,30,239,60,55,182,99,168,30,215,238,171,144,130,54,127,179,62,141,119,236,249,53,252,3,43,113,133,53,82,8,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateNoRightsToCopyProjectLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateNoRightsToCopyProjectLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("df1db353-f52f-401e-a2a5-76847c4bb6fe"),
				Name = "NoRightsToCopyProject",
				CreatedInPackageId = new Guid("c746724b-ad7f-4327-918b-435a466c9305"),
				CreatedInSchemaUId = new Guid("9b47c1bf-4868-454f-a509-c1a14ee81229"),
				ModifiedInSchemaUId = new Guid("9b47c1bf-4868-454f-a509-c1a14ee81229")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9b47c1bf-4868-454f-a509-c1a14ee81229"));
		}

		#endregion

	}

	#endregion

}

