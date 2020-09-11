namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IEsnMessageReaderSchema

	/// <exclude/>
	public class IEsnMessageReaderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IEsnMessageReaderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IEsnMessageReaderSchema(IEsnMessageReaderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("06f8b050-f68f-4336-acf7-4f1801ecd769");
			Name = "IEsnMessageReader";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,149,219,110,219,48,12,134,175,19,32,239,64,120,55,27,48,216,247,155,107,96,200,210,32,23,93,135,182,47,160,218,116,34,212,162,2,82,90,17,12,123,247,201,150,157,184,233,1,105,129,29,174,108,73,228,175,255,35,37,155,148,65,217,170,18,225,6,153,149,216,218,165,115,75,181,94,123,86,78,91,74,23,215,223,102,211,159,179,233,196,139,166,53,92,239,196,161,249,124,52,14,57,77,131,101,155,32,233,18,9,89,151,135,152,185,101,76,23,228,180,211,40,97,58,44,188,99,92,135,96,128,21,57,228,58,24,248,4,171,133,208,5,138,168,53,94,161,170,144,187,200,44,203,32,23,111,140,226,93,209,143,191,179,253,161,43,20,48,232,54,182,18,168,45,131,216,82,171,6,8,221,189,229,59,224,32,209,110,110,162,162,164,131,86,54,18,219,250,219,70,151,160,7,19,79,121,152,180,240,143,108,116,19,75,116,80,90,99,144,218,231,80,129,206,77,191,109,186,207,205,142,147,243,173,98,101,128,66,7,206,146,62,124,85,37,69,191,61,232,42,205,179,46,230,144,194,232,60,147,20,185,32,66,201,88,159,37,93,93,119,73,86,104,18,167,40,48,28,156,4,129,33,163,149,88,45,200,27,100,117,219,96,30,211,10,104,41,231,17,65,222,47,189,174,96,111,229,67,108,213,243,232,255,142,241,8,44,174,119,44,189,242,27,81,224,94,187,13,168,166,105,139,232,13,9,96,39,253,63,34,126,105,154,121,52,25,215,94,139,92,110,60,221,237,175,71,119,104,95,7,27,163,91,214,222,156,121,1,121,156,216,94,205,203,109,247,177,72,138,171,254,158,218,56,1,227,154,8,141,120,135,12,200,138,191,117,49,226,251,131,35,53,64,127,132,39,221,193,136,237,45,29,240,130,12,53,98,117,106,19,254,96,45,15,223,116,176,245,190,185,95,111,46,159,215,13,139,189,230,41,229,61,15,156,67,113,79,170,230,228,87,252,121,32,85,241,255,49,155,134,153,223,209,58,126,82,196,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("06f8b050-f68f-4336-acf7-4f1801ecd769"));
		}

		#endregion

	}

	#endregion

}

