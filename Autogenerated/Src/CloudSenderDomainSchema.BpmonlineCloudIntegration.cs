namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CloudSenderDomainSchema

	/// <exclude/>
	public class CloudSenderDomainSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CloudSenderDomainSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CloudSenderDomainSchema(CloudSenderDomainSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e61dae9a-2655-48a6-bc4a-42efa1e9c942");
			Name = "CloudSenderDomain";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,146,193,78,195,48,12,134,207,171,180,119,176,180,123,123,103,136,75,25,28,208,164,138,242,2,89,227,148,136,54,169,156,4,81,85,123,119,220,116,67,21,236,80,6,167,40,127,28,127,95,90,27,209,162,235,68,133,240,130,68,194,89,229,211,220,26,165,235,64,194,107,107,210,124,87,238,173,196,198,173,147,97,157,172,54,132,53,199,144,55,194,185,27,94,108,144,37,26,137,116,111,91,161,205,58,225,162,44,203,224,214,133,182,21,212,223,157,246,207,216,17,58,52,222,129,54,202,82,27,219,131,56,216,224,65,198,187,192,49,112,137,212,166,6,255,138,128,156,54,46,61,119,204,102,45,187,112,104,116,5,213,168,113,201,98,53,68,147,47,223,130,108,135,228,53,178,116,17,239,78,231,223,85,99,240,136,108,25,93,120,29,69,78,126,66,74,126,67,20,250,105,116,86,114,158,70,255,73,4,6,168,209,111,199,78,91,56,254,6,249,142,164,149,174,166,175,196,255,198,210,34,236,110,172,252,39,234,27,246,139,152,79,216,95,79,220,127,44,230,112,233,213,152,178,120,88,204,41,59,245,167,39,57,47,124,224,72,205,102,103,25,120,186,120,1,188,225,225,158,38,57,238,167,116,30,30,63,1,223,86,99,242,202,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e61dae9a-2655-48a6-bc4a-42efa1e9c942"));
		}

		#endregion

	}

	#endregion

}

