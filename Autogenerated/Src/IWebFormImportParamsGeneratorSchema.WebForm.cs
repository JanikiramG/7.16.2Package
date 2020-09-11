namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IWebFormImportParamsGeneratorSchema

	/// <exclude/>
	public class IWebFormImportParamsGeneratorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IWebFormImportParamsGeneratorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IWebFormImportParamsGeneratorSchema(IWebFormImportParamsGeneratorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5288477e-ed09-40b3-890c-492633a42375");
			Name = "IWebFormImportParamsGenerator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9d05c8ee-17e3-41aa-adfe-7e36f0a4c27c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,146,49,111,194,48,16,133,103,144,248,15,39,117,39,59,65,93,90,129,50,84,66,45,162,179,33,47,174,165,216,142,206,78,170,170,234,127,175,237,16,160,180,84,48,68,57,63,223,125,190,231,179,17,26,174,17,59,208,26,204,194,217,202,79,31,172,169,148,108,89,120,101,205,116,9,131,16,162,124,197,118,97,89,191,128,59,181,195,100,252,57,25,143,90,167,140,188,88,186,80,53,10,221,88,246,249,100,28,178,239,24,50,232,84,24,15,174,194,161,51,42,246,212,62,109,37,88,104,183,63,209,114,42,202,178,140,230,174,213,90,240,199,253,126,189,98,219,169,18,142,212,64,162,202,50,169,4,161,38,82,16,54,28,201,30,21,155,25,80,217,9,171,105,183,181,218,157,80,254,109,135,142,237,62,195,181,181,47,76,101,3,37,94,196,40,126,131,191,208,94,3,246,10,110,70,171,116,68,114,242,203,74,18,150,240,142,2,220,197,191,127,3,149,168,68,128,83,39,234,22,164,133,17,18,60,61,212,103,231,128,121,74,60,44,215,87,32,142,21,197,99,159,186,137,202,83,159,72,127,105,201,228,72,194,231,148,162,208,110,30,131,175,235,141,201,225,37,209,59,182,113,96,58,54,168,202,120,183,183,249,187,146,116,98,243,252,21,111,134,116,186,188,115,180,124,238,56,13,27,166,236,231,157,214,189,250,83,12,218,55,148,95,184,38,96,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5288477e-ed09-40b3-890c-492633a42375"));
		}

		#endregion

	}

	#endregion

}

