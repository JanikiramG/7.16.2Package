namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PRMOrderConstantsSchema

	/// <exclude/>
	public class PRMOrderConstantsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PRMOrderConstantsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PRMOrderConstantsSchema(PRMOrderConstantsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ee3a9e6e-8558-427d-9613-797cab16dcc3");
			Name = "PRMOrderConstants";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0cf4ca6-907d-4eba-86db-4399f9ff6801");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,144,203,106,195,48,16,69,215,49,248,31,68,186,105,22,142,193,117,243,104,218,46,108,43,93,149,152,54,63,160,218,99,35,176,229,48,26,81,76,200,191,87,145,250,10,100,53,204,189,119,14,51,163,68,15,250,32,42,96,123,64,20,122,104,104,158,15,170,145,173,65,65,114,80,97,112,12,131,137,209,82,181,236,125,212,4,253,38,12,172,114,131,208,90,155,229,157,208,250,129,149,111,175,59,172,1,237,172,38,161,72,187,208,193,124,116,178,98,86,33,91,170,115,244,90,114,114,116,233,63,230,143,101,185,142,224,237,56,142,217,163,54,125,47,112,124,246,2,43,81,218,221,59,169,137,149,2,73,1,218,34,250,92,16,180,3,142,76,214,160,72,54,18,112,254,139,136,255,51,46,87,124,49,178,246,204,51,242,42,241,137,41,248,116,193,219,105,86,20,219,140,39,73,148,172,139,52,74,183,156,71,43,94,44,35,126,159,37,233,122,177,92,172,248,221,116,182,249,190,14,84,237,15,116,253,201,191,241,66,60,125,1,23,128,227,164,143,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ee3a9e6e-8558-427d-9613-797cab16dcc3"));
		}

		#endregion

	}

	#endregion

}

