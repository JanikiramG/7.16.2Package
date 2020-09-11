namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ReportDataDictionarySchema

	/// <exclude/>
	public class ReportDataDictionarySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ReportDataDictionarySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ReportDataDictionarySchema(ReportDataDictionarySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c199853d-7f4a-40ab-afca-865c27583e7a");
			Name = "ReportDataDictionary";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0005402e-c4df-422a-beab-65ef1e6175ad");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,193,106,131,64,16,61,39,144,127,88,232,37,133,224,7,164,193,75,210,150,156,90,146,222,74,15,227,58,134,45,235,174,204,142,80,27,250,239,29,53,53,141,17,201,205,121,190,247,230,189,81,7,57,134,2,52,170,55,36,130,224,51,142,214,222,101,230,80,18,176,241,46,218,97,225,137,141,59,68,79,16,184,157,102,211,227,108,58,41,131,160,106,95,5,198,252,161,55,139,137,181,168,107,135,16,61,163,67,50,250,138,179,43,29,155,28,163,189,188,5,107,190,155,133,194,18,222,29,225,65,6,181,182,16,194,82,181,107,55,192,176,49,141,41,80,213,240,222,59,109,98,241,67,128,162,76,172,209,74,215,186,65,153,90,170,243,176,10,76,18,104,161,182,143,174,204,145,106,151,213,118,135,144,190,56,91,13,240,124,242,41,173,226,56,150,85,199,38,193,57,170,84,101,42,53,123,146,196,175,228,89,152,152,182,164,226,111,28,204,52,191,184,192,214,101,94,133,62,178,80,123,38,132,92,98,200,38,198,47,86,161,7,220,75,183,4,2,206,7,196,215,220,250,19,78,126,78,29,208,165,109,141,209,78,205,109,79,133,218,59,15,182,233,114,92,46,25,147,24,199,74,131,252,136,134,171,78,126,6,110,181,25,252,224,105,247,216,57,255,135,70,238,208,162,151,160,96,191,205,37,102,219,53,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c199853d-7f4a-40ab-afca-865c27583e7a"));
		}

		#endregion

	}

	#endregion

}

