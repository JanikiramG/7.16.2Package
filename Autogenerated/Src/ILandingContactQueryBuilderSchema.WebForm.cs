namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ILandingContactQueryBuilderSchema

	/// <exclude/>
	public class ILandingContactQueryBuilderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ILandingContactQueryBuilderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ILandingContactQueryBuilderSchema(ILandingContactQueryBuilderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("baa1b776-bab6-4f86-b3f2-e69f126a4c13");
			Name = "ILandingContactQueryBuilder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bb225b1d-9856-4e2d-8d05-b81de9745531");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,77,111,219,48,12,61,187,64,255,3,145,94,54,96,176,239,77,106,96,205,176,34,64,55,116,253,64,207,138,77,39,2,100,201,165,40,12,65,209,255,62,90,114,220,120,205,134,92,4,144,34,223,123,124,164,85,45,250,78,85,8,143,72,164,188,107,56,95,58,219,232,77,32,197,218,217,243,179,215,243,179,44,120,109,55,240,176,243,140,237,124,140,151,142,112,26,229,223,174,37,33,169,11,194,141,116,195,202,50,82,35,248,151,176,186,85,182,150,66,129,103,85,241,175,128,180,187,14,218,212,72,177,165,40,10,88,248,208,182,138,118,229,16,143,237,208,56,2,101,12,84,206,86,132,140,240,210,247,195,58,1,248,124,15,80,28,32,116,97,109,116,5,122,4,249,175,132,236,53,202,24,165,223,145,235,144,88,163,191,132,187,136,148,254,255,214,25,19,143,91,4,43,94,130,107,96,64,95,213,34,214,132,214,230,99,215,161,184,204,51,37,219,134,234,101,44,254,217,131,244,150,103,217,6,121,14,94,158,62,122,59,145,124,152,240,68,242,103,92,127,119,212,158,72,126,129,182,78,230,76,157,250,129,188,117,245,41,54,221,35,7,178,94,128,13,86,124,96,22,4,171,101,163,160,107,180,172,27,45,43,5,66,163,24,107,96,7,44,19,46,58,69,170,37,108,226,172,87,179,223,123,237,179,162,204,225,248,152,49,19,251,134,166,224,145,132,210,10,187,40,159,149,95,173,156,135,103,101,171,232,94,228,241,136,32,55,214,92,205,158,166,213,69,9,188,235,48,95,20,17,242,56,195,187,172,178,223,203,135,185,122,26,147,150,244,17,136,146,63,229,67,242,39,221,56,111,21,195,240,3,10,140,246,209,185,234,159,206,9,238,30,168,71,30,192,110,144,239,147,163,131,231,62,125,124,154,78,9,83,139,190,192,77,208,53,140,83,125,158,31,189,133,116,33,211,228,219,31,126,164,43,52,93,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("baa1b776-bab6-4f86-b3f2-e69f126a4c13"));
		}

		#endregion

	}

	#endregion

}

