namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IPushNotificationProviderSchema

	/// <exclude/>
	public class IPushNotificationProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IPushNotificationProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IPushNotificationProviderSchema(IPushNotificationProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e415681b-39a4-4c62-9fc4-58927242174a");
			Name = "IPushNotificationProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d653ba80-e9e2-4f78-8775-8ba14502d8a8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,146,193,106,195,48,12,134,207,9,228,29,4,187,108,48,146,123,91,10,163,133,209,195,70,89,251,2,158,173,100,98,142,29,44,167,80,70,223,125,142,147,149,174,36,101,187,4,199,210,247,139,15,217,136,26,185,17,18,97,143,206,9,182,165,207,87,214,148,84,181,78,120,178,38,75,191,178,52,105,153,76,5,187,35,123,172,67,93,107,148,93,145,243,103,52,232,72,206,179,52,116,221,57,172,194,45,108,140,71,87,134,208,25,108,182,45,127,188,90,79,37,201,152,183,117,246,64,10,93,4,138,162,128,5,183,117,45,220,113,57,252,159,97,176,37,52,129,6,115,129,67,51,240,156,255,240,197,69,64,211,190,107,146,64,231,140,27,243,147,78,44,57,88,82,176,67,163,238,175,59,215,194,11,80,225,243,16,236,146,83,111,24,26,123,201,95,194,43,45,152,103,48,150,48,233,249,134,141,67,70,227,121,196,178,27,123,75,80,118,3,39,230,245,94,67,35,123,215,109,110,111,63,209,64,44,36,21,250,121,60,240,112,232,213,174,9,242,26,255,69,188,32,179,168,254,200,172,41,62,160,96,181,232,241,199,33,102,9,79,74,81,172,233,184,129,233,184,209,157,156,190,1,169,78,189,67,210,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e415681b-39a4-4c62-9fc4-58927242174a"));
		}

		#endregion

	}

	#endregion

}

