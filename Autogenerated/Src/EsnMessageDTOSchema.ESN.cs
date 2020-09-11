namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EsnMessageDTOSchema

	/// <exclude/>
	public class EsnMessageDTOSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EsnMessageDTOSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EsnMessageDTOSchema(EsnMessageDTOSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6c636fc5-728b-4126-9e55-9608ee750af1");
			Name = "EsnMessageDTO";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,148,207,78,195,48,12,198,207,155,196,59,68,219,5,46,125,0,16,7,40,19,66,98,99,98,3,14,104,7,175,53,37,90,155,84,137,3,26,19,239,78,178,63,165,43,25,100,187,112,169,84,251,251,126,118,18,39,2,10,212,37,36,200,198,168,20,104,249,66,81,44,197,11,207,140,2,226,82,68,189,209,224,168,189,56,106,183,140,230,34,99,163,185,38,44,206,26,255,209,189,17,196,11,140,70,168,56,228,252,99,233,253,86,125,195,7,134,59,209,27,79,176,47,83,204,163,43,32,176,21,73,65,66,214,96,45,93,133,153,117,51,22,231,160,245,41,235,105,113,143,144,246,81,107,200,240,106,124,183,84,61,215,141,19,27,40,205,52,231,9,75,156,201,231,105,185,69,84,240,161,146,37,42,226,104,11,12,151,206,37,117,133,237,99,49,69,117,60,176,155,195,206,89,231,38,237,156,184,10,155,18,215,134,167,236,38,101,11,150,33,157,49,237,62,159,187,237,177,44,10,20,20,75,187,71,219,32,46,136,213,179,193,68,133,64,152,94,206,183,113,183,82,206,76,25,203,220,20,226,17,114,131,172,18,238,73,190,19,219,100,77,202,29,99,149,13,197,221,130,166,139,196,205,194,14,98,93,16,10,237,217,81,163,185,247,80,54,169,80,212,122,62,188,173,173,115,251,117,53,74,94,177,128,135,95,154,171,20,135,128,93,204,219,108,83,212,132,183,90,33,248,24,74,119,20,127,86,88,235,130,167,128,207,112,199,244,87,169,112,150,152,13,21,190,113,124,119,217,109,226,116,78,248,60,97,13,77,40,122,8,10,155,61,254,188,82,43,85,248,221,207,165,242,223,37,151,241,97,186,40,210,213,35,101,255,86,177,122,200,255,64,62,41,78,184,239,11,217,48,177,205,27,233,91,200,111,131,125,224,72,255,215,13,246,108,170,141,124,1,127,88,146,114,10,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6c636fc5-728b-4126-9e55-9608ee750af1"));
		}

		#endregion

	}

	#endregion

}

