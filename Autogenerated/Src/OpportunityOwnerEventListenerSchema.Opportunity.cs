namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OpportunityOwnerEventListenerSchema

	/// <exclude/>
	public class OpportunityOwnerEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OpportunityOwnerEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OpportunityOwnerEventListenerSchema(OpportunityOwnerEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("45b2d596-38cb-494e-80ad-afc0697d9ae4");
			Name = "OpportunityOwnerEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("1a637eec-ed5e-4e5a-93be-edcf08166986");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,81,193,78,3,33,20,60,111,147,254,195,203,122,209,11,220,107,235,193,166,183,198,30,234,205,120,64,250,118,37,89,30,27,30,216,16,227,191,11,91,171,171,86,123,32,97,134,25,222,48,144,178,200,189,210,8,247,232,189,98,215,4,177,116,212,152,54,122,21,140,163,233,228,117,58,169,34,27,106,97,155,56,160,189,254,196,99,139,199,191,120,177,162,96,130,65,62,43,16,171,23,164,80,116,89,121,225,177,205,243,97,217,41,230,25,172,81,237,54,123,66,63,104,214,38,39,201,96,80,74,41,97,206,209,90,229,211,205,7,62,10,192,53,224,246,195,134,96,211,247,206,135,72,38,36,192,50,51,137,163,93,254,240,207,25,81,117,236,64,123,108,22,245,255,129,197,173,98,28,184,244,45,93,13,178,220,247,112,226,232,114,171,159,209,170,187,92,63,44,160,30,37,171,175,30,179,167,143,79,157,209,160,203,227,199,185,127,87,0,51,248,26,127,170,161,170,124,96,149,215,219,161,87,164,221,161,218,2,51,247,14,32,78,178,134,3,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("45b2d596-38cb-494e-80ad-afc0697d9ae4"));
		}

		#endregion

	}

	#endregion

}

