namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ExcelCellFormatSchema

	/// <exclude/>
	public class ExcelCellFormatSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ExcelCellFormatSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ExcelCellFormatSchema(ExcelCellFormatSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5521b4a2-bdcb-488d-b088-5f4a850b95ea");
			Name = "ExcelCellFormat";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,146,91,75,195,64,16,133,159,91,232,127,24,240,165,133,144,164,23,47,84,43,104,91,169,32,42,182,138,32,62,108,211,73,186,184,151,184,217,197,170,244,191,187,187,169,32,74,172,62,36,48,153,115,78,62,14,35,8,199,34,39,9,194,12,149,34,133,76,117,56,148,34,165,153,81,68,83,41,194,241,42,151,74,207,228,120,149,32,107,212,223,27,245,70,189,102,10,42,50,24,201,196,112,20,250,76,42,78,116,120,149,163,184,231,44,156,230,10,201,162,88,34,234,67,175,222,81,152,217,40,24,11,195,251,224,131,134,200,88,105,243,138,40,138,224,168,48,156,19,245,122,188,153,189,14,236,195,32,245,74,64,235,15,63,213,209,23,121,110,230,140,38,126,255,51,190,102,145,107,181,7,255,253,210,240,57,170,114,211,76,9,43,176,245,232,182,167,82,50,24,64,59,168,144,106,101,48,128,78,220,190,181,239,110,233,25,17,141,214,211,217,226,113,142,56,128,38,21,186,53,145,138,190,73,161,9,59,97,52,19,174,187,59,194,12,22,225,13,205,150,122,147,139,9,229,196,225,116,171,162,61,121,0,207,70,106,188,86,152,210,85,31,220,239,202,128,137,109,31,149,245,247,126,71,107,255,27,237,92,104,27,187,187,5,235,133,46,244,178,15,189,184,146,112,170,149,187,159,1,236,109,43,60,254,86,248,140,114,87,250,254,223,16,58,221,74,132,11,41,159,76,110,163,14,236,180,46,207,20,197,162,188,84,55,174,63,0,132,233,52,86,27,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5521b4a2-bdcb-488d-b088-5f4a850b95ea"));
		}

		#endregion

	}

	#endregion

}

