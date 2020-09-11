namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CloudSenderDomainsInfoSchema

	/// <exclude/>
	public class CloudSenderDomainsInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CloudSenderDomainsInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CloudSenderDomainsInfoSchema(CloudSenderDomainsInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f2e8d79a-460e-4a42-b17f-4d076f55b6e6");
			Name = "CloudSenderDomainsInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,213,84,75,111,219,48,12,62,183,64,255,3,209,30,118,179,239,75,218,75,210,22,93,151,33,136,135,222,85,139,242,132,200,146,33,202,25,130,96,255,189,148,148,24,125,172,131,179,67,129,158,4,147,212,247,32,101,90,209,34,117,162,70,248,137,222,11,114,42,20,51,103,149,110,122,47,130,118,182,152,93,87,11,39,209,208,217,233,238,236,244,164,39,109,27,168,182,20,176,229,74,99,176,142,101,84,220,162,69,175,235,201,80,243,3,127,7,78,68,196,111,228,44,39,56,117,225,177,225,114,152,25,65,244,149,15,215,203,10,173,68,63,119,173,208,150,238,172,114,169,178,44,75,152,82,223,182,194,111,175,246,223,43,236,60,18,218,64,192,103,199,232,8,78,65,248,133,64,232,55,154,109,40,231,57,23,188,198,77,20,33,51,106,10,243,69,25,99,200,33,83,28,40,202,103,28,93,255,104,116,13,117,20,247,174,182,147,93,210,55,88,89,122,215,161,15,26,217,207,50,1,228,252,107,3,41,112,139,172,61,105,225,51,234,62,8,20,86,130,14,95,56,217,229,126,14,16,229,107,140,41,33,10,67,14,106,143,234,242,252,185,196,243,50,85,237,125,124,215,20,166,111,108,92,193,222,14,236,160,193,48,137,90,38,240,231,40,209,168,68,111,2,200,181,110,11,224,247,18,18,222,70,152,30,65,43,232,188,219,104,38,204,55,226,107,48,8,107,220,166,49,8,99,14,174,223,49,185,151,79,60,69,30,215,60,147,205,239,239,22,247,12,241,73,68,179,218,21,214,206,203,255,23,92,45,111,178,186,81,140,85,167,30,146,149,15,226,155,115,124,125,28,99,126,119,145,67,203,180,92,248,79,141,45,26,199,151,46,63,12,119,143,236,238,234,176,47,40,136,208,143,27,98,149,74,143,167,168,121,95,254,155,64,219,192,47,80,142,111,221,128,205,235,154,68,51,110,68,139,92,251,55,146,11,94,8,121,127,165,239,28,125,25,228,216,19,44,185,22,246,30,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f2e8d79a-460e-4a42-b17f-4d076f55b6e6"));
		}

		#endregion

	}

	#endregion

}

