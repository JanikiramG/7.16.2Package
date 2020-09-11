namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LeadQueryBuilderSchema

	/// <exclude/>
	public class LeadQueryBuilderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LeadQueryBuilderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LeadQueryBuilderSchema(LeadQueryBuilderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9acaacd9-1b19-46c1-86a0-02778a5ef41c");
			Name = "LeadQueryBuilder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fc0e3e3b-059a-41c0-ac9d-be82e0250c11");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,144,61,107,195,48,16,134,231,24,242,31,142,116,105,151,120,79,211,14,49,45,20,66,105,32,208,249,44,157,93,129,44,185,39,169,193,132,252,247,74,150,155,38,217,116,167,71,239,135,12,118,228,122,20,4,123,98,70,103,27,191,172,172,105,84,27,24,189,178,102,94,28,231,197,188,152,221,49,181,113,132,74,163,115,43,120,249,33,227,247,200,45,249,93,32,30,54,65,105,73,60,162,101,89,194,218,133,174,67,30,158,167,57,106,10,38,79,240,157,104,168,51,14,141,101,64,173,225,64,117,58,119,14,14,202,127,193,150,80,130,31,122,90,254,201,149,23,122,125,168,181,18,224,8,53,73,16,41,208,248,226,50,8,172,96,139,70,42,211,70,103,143,226,42,229,58,209,73,41,87,251,239,102,141,243,28,132,183,28,43,126,140,54,153,152,44,111,93,238,31,162,79,141,142,226,225,152,184,217,39,213,175,177,199,155,172,172,14,157,121,143,223,11,79,176,56,175,23,143,35,54,133,186,197,118,1,181,106,20,201,243,125,230,79,83,78,50,50,71,29,231,188,189,94,158,126,1,85,188,145,69,209,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9acaacd9-1b19-46c1-86a0-02778a5ef41c"));
		}

		#endregion

	}

	#endregion

}

