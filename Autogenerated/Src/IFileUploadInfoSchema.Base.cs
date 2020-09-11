namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFileUploadInfoSchema

	/// <exclude/>
	public class IFileUploadInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFileUploadInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFileUploadInfoSchema(IFileUploadInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("28ad8049-6da4-4639-b9de-e5c9a1fd33d3");
			Name = "IFileUploadInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,148,91,79,27,49,16,133,159,23,137,255,48,18,175,85,242,78,17,82,27,46,90,9,149,136,164,188,59,235,217,205,128,47,43,95,144,86,21,255,189,99,175,160,41,176,16,195,163,173,111,206,241,28,219,99,132,70,223,139,6,97,141,206,9,111,219,48,91,88,211,82,23,157,8,100,205,236,130,20,254,238,149,21,242,240,224,207,225,65,21,61,153,14,86,131,15,168,191,191,88,115,169,82,216,164,58,63,187,68,131,142,154,87,76,125,205,91,188,121,228,176,99,16,106,19,208,181,124,132,99,168,255,153,213,166,181,25,235,227,70,81,3,244,68,189,134,170,116,172,103,185,165,179,61,186,64,232,143,97,153,107,179,76,53,159,207,225,196,71,173,133,27,78,159,54,146,20,160,9,20,6,240,205,22,181,0,195,137,204,158,11,230,187,21,62,184,212,199,121,230,87,25,255,197,52,100,255,170,195,144,122,173,30,223,241,59,19,65,188,240,107,172,138,218,236,97,187,200,96,161,97,110,240,99,237,132,125,70,153,100,106,166,37,116,19,250,151,145,100,70,107,89,170,29,134,126,95,131,53,163,69,6,107,27,132,130,54,217,40,52,93,216,78,168,75,108,72,51,153,249,116,170,171,76,23,56,45,133,227,14,246,191,229,145,255,212,93,255,111,245,32,84,156,242,202,161,237,58,221,38,184,244,130,26,203,127,210,132,9,143,85,112,40,52,191,218,12,21,104,255,144,146,210,4,225,216,123,225,56,2,254,248,126,194,228,140,242,176,225,229,201,152,223,55,176,155,59,158,64,167,59,50,203,164,226,75,126,105,178,212,100,208,3,181,64,1,200,67,179,141,230,30,37,196,60,120,38,142,179,177,86,65,237,23,35,59,206,168,2,223,159,67,64,112,194,116,31,188,145,196,221,36,172,244,198,30,56,201,52,211,223,86,231,17,11,183,35,241,197,176,90,114,62,140,145,189,159,212,69,2,115,92,111,59,30,161,145,227,92,231,213,184,183,187,245,248,23,207,19,239,225,191,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("28ad8049-6da4-4639-b9de-e5c9a1fd33d3"));
		}

		#endregion

	}

	#endregion

}

