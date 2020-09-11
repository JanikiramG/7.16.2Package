namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PRMTransactionEventListenerSchema

	/// <exclude/>
	public class PRMTransactionEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PRMTransactionEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PRMTransactionEventListenerSchema(PRMTransactionEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d4d7f2bb-ef0a-4afa-b11f-2249cce4c609");
			Name = "PRMTransactionEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("93e06cc5-eabd-4f73-bbbe-f0e6647a43ae");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,84,193,142,155,48,16,61,179,210,254,195,136,30,150,72,149,185,103,67,164,221,40,221,86,234,182,171,38,109,15,85,15,14,12,193,21,216,200,54,169,162,213,254,123,7,27,34,136,72,122,65,248,121,230,205,155,55,12,146,87,104,106,158,34,108,81,107,110,84,110,217,74,201,92,236,27,205,173,80,242,246,230,245,246,38,104,140,144,123,216,28,141,197,234,254,116,30,166,104,188,132,179,181,180,194,10,52,255,13,96,235,3,74,123,57,238,3,79,173,210,215,152,54,214,11,161,251,119,26,247,164,31,86,37,55,102,14,47,223,158,183,154,75,67,20,132,186,66,159,5,181,35,81,187,240,56,142,97,97,154,170,226,250,184,236,206,125,0,228,74,195,221,152,225,14,176,85,125,4,116,154,89,79,17,159,113,44,12,34,47,141,130,84,99,158,132,215,59,103,143,220,160,195,142,35,133,33,196,45,223,175,137,171,104,147,22,88,241,47,52,71,72,32,28,139,12,103,191,41,173,110,118,165,72,33,109,141,184,230,3,204,225,66,125,34,121,117,46,157,92,125,70,91,168,172,245,213,145,251,203,115,15,29,240,145,203,172,68,211,219,181,225,135,118,110,206,53,118,74,138,207,179,22,53,215,188,2,73,109,37,161,65,153,145,9,75,167,9,252,137,45,98,23,50,157,129,225,114,91,160,51,191,55,126,126,209,122,39,236,33,183,168,93,129,7,189,55,173,225,32,164,177,92,210,106,164,74,90,46,100,171,219,22,216,23,116,45,64,198,45,31,105,233,220,86,7,42,39,50,132,131,18,25,124,149,190,239,72,237,254,96,218,247,240,30,124,237,71,164,15,12,79,197,1,103,208,46,93,16,248,107,168,117,53,156,153,7,19,136,252,219,204,147,221,187,140,167,134,170,145,24,75,83,51,133,168,63,101,20,56,149,207,158,208,110,143,53,102,43,85,54,149,252,193,203,6,23,109,246,50,10,95,134,249,225,204,51,139,28,162,51,226,4,218,4,182,174,106,82,209,73,14,70,149,180,160,175,83,131,157,192,18,144,248,23,38,162,163,73,185,223,13,106,250,49,73,116,96,167,41,152,32,102,254,101,192,240,83,216,98,208,210,36,127,71,248,230,158,59,218,2,118,26,89,63,43,244,49,111,221,34,16,234,119,193,157,61,58,6,9,251,7,218,144,216,139,95,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d4d7f2bb-ef0a-4afa-b11f-2249cce4c609"));
		}

		#endregion

	}

	#endregion

}

