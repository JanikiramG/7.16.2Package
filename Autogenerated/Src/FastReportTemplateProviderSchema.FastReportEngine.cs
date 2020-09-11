namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FastReportTemplateProviderSchema

	/// <exclude/>
	public class FastReportTemplateProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FastReportTemplateProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FastReportTemplateProviderSchema(FastReportTemplateProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("83618497-e4f6-47f6-afb0-46374352918b");
			Name = "FastReportTemplateProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("907f2de3-5104-49b3-a54a-bb8730240b72");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,82,203,106,195,48,16,60,59,144,127,88,232,197,189,248,3,146,182,80,66,29,114,8,132,212,61,23,197,218,56,162,182,100,86,82,74,8,253,247,174,236,60,106,227,4,122,220,221,153,157,153,149,180,168,208,214,34,71,200,144,72,88,179,117,201,204,232,173,42,60,9,167,140,78,214,88,27,114,74,23,73,42,172,107,171,55,93,40,141,227,209,113,60,138,188,229,25,188,31,172,195,106,218,171,147,108,71,40,100,32,103,194,126,217,235,252,63,106,195,44,194,161,254,16,63,121,221,88,71,34,15,2,193,2,211,30,8,11,174,96,86,10,107,39,112,197,102,88,213,165,112,184,34,179,87,18,169,65,215,126,83,170,28,242,0,190,131,133,9,44,110,109,137,142,205,166,139,112,170,176,148,172,188,34,181,103,96,59,172,219,2,194,205,140,46,15,3,90,75,161,69,193,82,159,174,219,152,158,214,163,150,173,66,87,142,143,204,39,240,185,51,20,68,155,60,39,205,54,219,237,84,241,135,69,98,190,198,230,128,224,59,229,35,132,63,16,69,125,63,240,12,26,191,111,7,136,123,107,194,91,70,63,247,67,44,209,237,140,28,246,31,190,215,19,71,228,151,127,129,57,186,120,238,149,132,179,169,133,60,251,220,11,186,116,217,99,223,118,194,212,179,211,248,15,187,177,23,17,58,79,186,209,74,82,50,213,26,173,47,221,5,119,47,68,219,237,54,185,247,11,243,228,238,35,127,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("83618497-e4f6-47f6-afb0-46374352918b"));
		}

		#endregion

	}

	#endregion

}

