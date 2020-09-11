namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LeadLanguageIteratorSchema

	/// <exclude/>
	public class LeadLanguageIteratorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LeadLanguageIteratorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LeadLanguageIteratorSchema(LeadLanguageIteratorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1252c774-91a4-464b-aa1f-d627521faa81");
			Name = "LeadLanguageIterator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("df5a8bee-e0f6-4225-b7c8-127f6fd1b1ca");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,81,77,107,195,48,12,61,167,208,255,32,178,75,11,35,185,247,11,182,238,82,40,108,140,245,52,118,80,93,37,24,28,59,248,131,209,149,254,247,41,78,218,181,89,161,7,99,36,189,247,244,36,105,172,200,213,40,8,62,200,90,116,166,240,217,210,232,66,150,193,162,151,70,15,7,135,225,32,9,78,234,242,10,98,105,58,28,112,229,193,82,201,48,88,42,116,110,2,175,117,109,172,15,90,250,253,26,117,25,176,164,149,39,150,50,54,194,243,60,135,153,11,85,133,118,191,232,226,19,0,10,126,74,58,223,244,218,238,65,17,238,64,117,42,46,59,177,243,11,122,29,182,74,10,16,77,115,88,51,190,223,20,38,240,140,142,254,123,73,14,209,207,159,127,163,157,183,65,112,145,199,120,139,186,45,162,111,185,245,204,19,74,84,242,135,28,104,250,6,201,108,212,188,70,83,48,152,8,132,165,98,158,222,178,148,230,139,12,206,194,121,95,121,86,163,197,10,52,31,102,158,6,71,150,157,105,18,205,45,210,197,134,99,16,231,68,54,203,35,58,146,187,93,220,106,57,218,92,233,192,181,236,184,97,39,201,4,182,188,169,81,175,6,135,88,61,41,190,7,197,19,207,227,204,171,203,228,231,87,135,76,154,18,11,120,20,126,165,47,221,52,176,158,147,241,35,220,32,61,9,97,130,246,119,185,127,212,23,42,48,40,127,31,125,156,54,223,177,187,61,233,93,123,254,24,183,217,235,228,241,23,208,239,76,12,33,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1252c774-91a4-464b-aa1f-d627521faa81"));
		}

		#endregion

	}

	#endregion

}

