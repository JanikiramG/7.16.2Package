namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IEsnMessageRedactorSchema

	/// <exclude/>
	public class IEsnMessageRedactorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IEsnMessageRedactorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IEsnMessageRedactorSchema(IEsnMessageRedactorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("95f9fa02-7c86-4d9f-a8c2-7614daa3758a");
			Name = "IEsnMessageRedactor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,85,203,110,194,48,16,60,131,196,63,172,232,161,84,66,201,189,165,92,0,85,28,250,80,169,212,179,137,55,196,106,108,35,175,83,132,42,254,189,198,113,2,20,74,75,31,199,181,119,103,103,198,19,69,49,137,52,103,9,194,19,26,195,72,167,54,26,104,149,138,89,97,152,21,90,69,163,201,93,171,249,214,106,54,10,18,106,6,147,37,89,148,87,117,61,208,6,163,145,178,194,10,36,119,236,46,206,12,206,220,36,192,88,89,52,169,3,191,132,241,136,212,45,18,177,25,62,34,103,137,213,198,247,198,113,12,61,42,164,100,102,217,15,245,131,209,175,130,35,129,68,155,105,78,144,106,3,164,19,193,114,80,104,23,218,188,128,241,32,107,2,178,68,165,168,66,139,183,224,230,197,52,23,9,136,138,200,97,30,141,181,188,61,42,37,23,77,22,112,45,111,121,78,213,174,168,110,143,63,246,247,230,204,48,9,202,217,122,221,14,237,67,102,89,187,31,182,2,119,85,212,139,125,95,61,182,16,54,3,155,33,100,152,207,65,167,142,8,34,36,6,211,235,182,99,252,108,132,197,0,48,124,186,111,199,125,79,225,166,16,220,51,12,87,157,253,86,216,226,112,81,62,207,17,161,161,217,41,77,180,148,78,246,137,74,199,124,163,115,204,247,84,238,140,132,13,165,57,131,178,248,23,115,2,118,199,31,212,68,187,112,192,172,45,78,71,205,26,113,241,235,84,108,156,90,100,154,96,138,128,14,21,191,112,109,39,82,19,107,182,190,128,211,124,243,228,43,175,166,90,231,94,84,29,36,127,93,33,119,129,118,54,125,207,159,31,135,41,180,111,82,113,138,65,59,177,10,6,85,251,63,14,254,196,161,42,77,193,161,0,93,59,244,221,4,13,49,71,139,127,159,33,238,113,247,61,58,85,106,201,239,112,28,254,83,216,167,111,255,183,194,14,191,226,90,88,99,85,254,195,80,241,242,55,214,106,174,222,1,150,63,160,220,37,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("95f9fa02-7c86-4d9f-a8c2-7614daa3758a"));
		}

		#endregion

	}

	#endregion

}

