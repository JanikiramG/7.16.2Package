namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DateTimeExcelCellWriterSchema

	/// <exclude/>
	public class DateTimeExcelCellWriterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DateTimeExcelCellWriterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DateTimeExcelCellWriterSchema(DateTimeExcelCellWriterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2cb26043-42ca-4c84-9e87-fb66c4e44a45");
			Name = "DateTimeExcelCellWriter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,144,49,111,194,48,16,133,103,34,229,63,156,196,30,239,37,176,164,116,206,16,137,217,117,14,106,201,246,69,103,167,13,66,252,247,218,14,65,8,196,224,225,221,189,119,239,147,157,180,232,7,169,16,58,100,150,158,142,161,106,200,29,245,105,100,25,52,185,106,63,13,196,161,163,253,164,208,148,197,165,44,86,107,198,83,92,65,99,164,247,31,240,41,3,118,218,98,118,52,104,204,129,117,64,46,139,104,21,66,64,237,71,107,37,159,119,55,189,248,1,83,0,226,51,240,151,35,213,146,16,15,145,97,252,54,90,129,74,101,239,186,96,166,120,33,88,37,220,59,111,203,52,32,7,141,17,186,205,87,51,99,170,172,181,251,193,24,234,73,129,72,173,75,45,253,198,127,209,61,194,253,246,23,177,149,225,69,111,119,207,163,106,129,221,204,53,107,116,253,76,18,213,53,207,30,71,215,127,54,37,12,49,140,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2cb26043-42ca-4c84-9e87-fb66c4e44a45"));
		}

		#endregion

	}

	#endregion

}

