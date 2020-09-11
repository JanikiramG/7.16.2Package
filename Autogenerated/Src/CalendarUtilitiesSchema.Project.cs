namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CalendarUtilitiesSchema

	/// <exclude/>
	public class CalendarUtilitiesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CalendarUtilitiesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CalendarUtilitiesSchema(CalendarUtilitiesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("62f7c1b7-845c-4ca7-86ea-eb981e255cb0");
			Name = "CalendarUtilities";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,93,79,227,48,16,124,14,18,255,97,143,7,148,220,33,139,123,65,72,168,72,208,86,8,137,19,210,149,170,207,78,178,41,62,146,53,172,215,234,85,39,254,251,217,105,72,10,42,31,74,226,216,187,227,153,241,122,189,51,180,132,217,218,9,54,103,251,123,190,93,222,33,179,118,182,18,53,182,77,99,105,103,130,241,157,176,154,92,246,153,13,177,186,49,244,244,54,54,182,117,141,133,24,75,78,93,33,33,155,98,39,33,85,102,233,89,71,224,123,130,83,18,35,6,221,142,252,252,90,45,48,15,44,194,182,118,234,101,242,145,153,219,252,79,152,254,178,37,214,1,182,121,30,125,94,155,2,156,4,31,5,20,181,118,14,198,186,70,42,53,207,197,212,173,60,252,219,223,75,94,35,13,9,92,161,44,44,63,4,181,59,211,224,37,202,10,145,38,90,208,165,113,140,193,8,103,137,171,35,232,99,129,188,141,204,29,114,240,77,27,127,224,95,45,179,86,52,97,20,207,180,37,53,209,107,151,110,177,118,100,25,124,135,211,240,157,28,135,163,37,207,159,248,109,73,190,226,177,115,209,35,96,52,160,85,28,162,90,210,129,67,178,155,13,41,83,193,224,22,206,223,240,38,114,207,118,5,132,43,184,224,165,111,144,100,250,183,192,199,88,128,244,224,154,10,203,28,202,1,225,90,4,74,189,134,3,248,209,83,180,252,207,91,69,130,41,5,10,214,121,141,234,183,166,37,166,199,71,240,115,216,161,102,62,23,214,133,12,142,50,21,75,145,181,94,212,12,99,171,164,182,170,28,10,140,206,183,142,122,81,150,109,205,54,185,172,219,176,184,71,198,52,250,10,224,240,139,100,183,213,2,241,1,190,141,94,58,176,143,169,153,14,54,35,250,240,240,43,104,31,122,112,221,41,141,173,39,73,179,238,110,195,251,31,209,59,196,200,223,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("62f7c1b7-845c-4ca7-86ea-eb981e255cb0"));
		}

		#endregion

	}

	#endregion

}

