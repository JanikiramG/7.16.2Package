namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OpportunityMLangBinderSchema

	/// <exclude/>
	public class OpportunityMLangBinderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OpportunityMLangBinderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OpportunityMLangBinderSchema(OpportunityMLangBinderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c44c1193-13fd-4b69-b47e-53e7dc114349");
			Name = "OpportunityMLangBinder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0e987dc8-e3a7-4136-b3d3-af8a5676bbce");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,81,75,107,195,48,12,62,167,208,255,32,186,75,7,35,185,183,165,208,150,13,10,41,29,108,176,179,147,168,153,33,126,96,203,97,161,244,191,207,177,147,145,142,158,140,244,61,164,79,150,76,160,213,172,68,248,68,99,152,85,23,74,15,74,94,120,237,12,35,174,228,124,118,157,207,18,103,185,172,239,40,6,211,55,86,146,50,28,237,250,1,227,11,11,207,18,66,73,143,122,252,201,96,237,237,224,208,48,107,87,112,214,90,25,114,146,83,119,202,153,172,247,92,86,104,2,51,203,50,216,88,39,4,51,221,118,168,39,116,16,174,33,222,120,141,99,53,66,217,251,65,17,228,233,168,206,38,114,237,138,134,151,3,239,241,88,88,193,78,235,215,22,37,229,220,18,74,52,123,102,209,139,175,97,163,191,229,79,72,223,170,242,235,191,7,211,8,14,3,84,235,179,243,10,161,85,188,130,179,244,142,31,196,12,45,71,107,127,86,194,31,130,50,190,207,208,31,54,73,10,63,41,157,208,71,120,29,208,112,174,120,232,46,237,183,221,28,243,33,250,145,208,127,145,50,47,211,84,255,193,237,114,49,65,23,209,245,54,164,66,89,197,96,161,142,221,251,230,237,23,216,24,93,152,32,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c44c1193-13fd-4b69-b47e-53e7dc114349"));
		}

		#endregion

	}

	#endregion

}

