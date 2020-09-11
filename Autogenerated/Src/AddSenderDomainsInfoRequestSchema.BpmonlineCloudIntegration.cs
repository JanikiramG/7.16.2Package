namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AddSenderDomainsInfoRequestSchema

	/// <exclude/>
	public class AddSenderDomainsInfoRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AddSenderDomainsInfoRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AddSenderDomainsInfoRequestSchema(AddSenderDomainsInfoRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7cef863d-9684-4a82-a74b-e9746da57616");
			Name = "AddSenderDomainsInfoRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,82,203,78,195,48,16,60,83,169,255,176,10,23,184,36,247,62,144,160,69,136,67,81,213,244,134,56,108,147,77,176,20,219,101,215,41,42,21,255,142,99,183,60,90,4,39,107,199,51,163,157,209,26,212,36,107,44,8,150,196,140,98,43,151,78,172,169,84,221,50,58,101,77,58,185,205,103,182,164,70,250,189,93,191,215,239,157,181,162,76,13,249,86,28,233,116,209,26,167,52,165,57,177,194,70,189,5,205,48,240,206,153,106,63,192,164,65,145,1,92,151,101,78,166,36,158,90,141,202,200,189,169,236,130,94,90,18,23,232,89,150,193,72,90,173,145,183,87,251,57,72,161,178,12,28,153,224,44,96,89,130,161,87,144,224,6,101,176,75,15,14,217,145,197,72,136,176,17,11,5,83,53,78,254,77,153,222,160,144,79,179,81,5,237,215,75,32,235,220,30,167,232,208,171,28,99,225,158,60,176,110,87,141,42,160,8,75,254,17,15,6,112,106,234,245,177,206,207,158,230,108,215,196,78,145,47,107,30,172,227,255,113,49,1,184,35,39,224,123,145,238,117,207,244,173,134,211,30,34,178,193,166,165,207,113,249,155,230,139,18,194,206,72,175,136,47,30,252,141,192,24,146,72,79,46,187,236,135,240,226,184,187,134,24,26,118,80,147,27,118,75,13,225,125,159,206,151,18,3,134,57,162,63,65,143,125,0,154,31,190,237,135,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7cef863d-9684-4a82-a74b-e9746da57616"));
		}

		#endregion

	}

	#endregion

}

