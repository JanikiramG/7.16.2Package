namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DateExcelCellWriterSchema

	/// <exclude/>
	public class DateExcelCellWriterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DateExcelCellWriterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DateExcelCellWriterSchema(DateExcelCellWriterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("73d3a6ae-b385-4134-8118-e70bf2e8f09f");
			Name = "DateExcelCellWriter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,146,223,107,219,48,16,199,159,29,200,255,112,180,123,176,97,216,239,109,87,40,105,6,131,109,9,52,172,123,85,236,115,162,33,233,204,73,78,99,138,255,247,73,242,143,150,165,236,193,63,238,244,213,125,63,119,146,17,26,109,35,74,132,29,50,11,75,181,203,87,100,106,121,104,89,56,73,38,95,159,27,98,183,163,245,185,68,181,92,188,46,23,73,107,165,57,192,83,103,29,234,219,229,194,103,174,25,15,94,12,43,37,172,189,129,71,225,48,234,87,168,212,51,75,135,28,101,69,81,192,157,109,181,22,220,221,143,113,208,2,6,49,248,71,193,75,148,231,147,186,120,39,111,218,189,146,37,148,193,228,35,15,240,206,88,74,45,212,133,121,18,184,103,204,45,83,131,236,36,122,214,109,44,26,241,130,227,157,52,71,244,155,42,42,161,8,166,147,43,157,252,128,100,133,48,215,254,74,172,133,187,136,191,220,255,155,202,3,235,48,168,228,26,77,53,80,140,241,136,244,3,221,145,170,192,195,228,176,116,88,253,15,105,210,188,81,89,199,225,80,6,195,95,66,181,152,210,254,143,23,193,41,4,25,196,1,36,39,193,192,104,91,229,57,199,61,249,90,55,174,187,141,203,178,134,52,192,238,164,198,124,199,221,86,176,197,52,86,200,119,244,20,245,105,246,25,168,13,117,25,42,175,141,102,217,100,144,56,238,166,223,100,118,154,117,190,202,230,33,56,164,217,91,193,77,131,230,183,86,63,91,189,71,30,58,248,102,106,202,6,166,164,135,82,184,242,8,233,198,55,91,43,122,9,227,109,194,229,244,247,102,246,77,190,147,111,133,153,56,253,116,245,193,229,200,97,69,173,170,192,144,131,122,56,169,216,215,13,188,206,116,125,14,115,109,159,199,115,127,53,67,196,207,240,102,116,45,155,113,142,113,189,191,60,220,49,247,62,213,255,5,172,214,156,24,110,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("73d3a6ae-b385-4134-8118-e70bf2e8f09f"));
		}

		#endregion

	}

	#endregion

}

