namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PortalSchemaAccessListEventListenerSchema

	/// <exclude/>
	public class PortalSchemaAccessListEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PortalSchemaAccessListEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PortalSchemaAccessListEventListenerSchema(PortalSchemaAccessListEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9f33f8d7-fd5c-42c2-b59b-96e61f427ef7");
			Name = "PortalSchemaAccessListEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d7352345-17a4-46e8-b32e-306ac0453d7a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,229,83,77,111,219,48,12,61,167,64,255,3,225,30,154,0,131,124,79,147,0,153,87,96,135,125,20,112,119,26,118,96,100,218,209,32,83,129,36,103,8,138,253,247,201,82,92,52,129,179,21,59,13,216,205,34,249,200,199,247,76,198,150,220,14,37,193,35,89,139,206,212,94,20,134,107,213,116,22,189,50,124,125,245,116,125,53,233,156,226,230,164,196,210,221,133,184,184,103,175,188,34,247,199,2,113,191,39,246,151,235,74,159,198,132,252,141,165,38,176,129,66,163,115,115,120,48,214,163,46,229,150,90,92,75,73,206,125,80,206,199,118,253,7,49,217,8,203,243,28,22,174,107,91,180,135,213,241,61,20,64,109,44,220,142,119,186,5,234,57,30,128,34,67,49,180,202,207,122,45,28,17,106,103,64,90,170,151,217,239,247,20,111,209,81,140,29,78,152,102,144,247,253,190,142,164,166,137,216,167,224,18,44,33,27,39,155,205,190,5,248,174,219,104,37,65,246,2,189,70,31,152,195,5,62,161,217,83,84,239,89,245,143,228,183,166,234,117,143,67,82,242,92,219,24,120,143,92,105,114,131,124,37,238,169,74,34,138,103,76,126,14,90,236,208,98,11,28,182,92,102,142,184,10,154,172,34,37,72,47,177,200,99,201,56,130,178,213,227,150,162,23,131,15,243,139,78,68,94,235,218,147,141,3,214,182,113,189,254,160,216,121,228,112,7,210,176,71,197,253,239,232,183,52,12,140,43,64,133,30,79,184,28,69,55,251,48,78,85,4,123,163,42,248,204,113,237,169,217,124,39,57,172,240,6,198,70,3,205,160,191,175,201,100,19,188,16,3,114,128,208,236,46,38,19,20,118,47,92,13,191,195,52,133,103,169,58,85,150,229,67,73,178,179,189,167,220,40,38,81,104,66,91,96,0,85,107,173,205,15,170,10,163,187,150,221,244,101,59,241,197,145,13,135,207,129,113,112,60,205,253,249,122,163,223,145,38,255,63,90,125,92,252,175,204,30,176,255,150,221,55,161,127,186,251,248,78,209,211,96,136,253,2,9,67,239,228,57,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9f33f8d7-fd5c-42c2-b59b-96e61f427ef7"));
		}

		#endregion

	}

	#endregion

}

