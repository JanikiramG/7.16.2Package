namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LeadOwnerEventListenerSchema

	/// <exclude/>
	public class LeadOwnerEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LeadOwnerEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LeadOwnerEventListenerSchema(LeadOwnerEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("265f0b5e-a6be-455d-942d-40f04c0b5236");
			Name = "LeadOwnerEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,144,63,111,2,49,12,197,103,144,248,14,214,117,105,151,100,167,208,161,136,13,181,3,108,85,7,55,248,174,145,46,14,138,115,160,19,226,187,147,132,210,127,130,118,203,115,126,182,159,31,163,35,217,160,33,88,81,8,40,190,142,106,230,185,182,77,23,48,90,207,163,225,126,52,28,116,98,185,129,101,47,145,220,253,167,254,222,18,232,90,93,205,57,218,104,73,254,5,212,124,75,28,51,151,200,155,64,77,218,15,179,22,69,198,176,32,92,63,239,152,66,97,22,54,57,73,162,144,90,107,152,72,231,28,134,254,225,67,159,1,240,53,248,93,121,112,153,1,148,151,245,234,220,167,127,53,78,132,8,91,241,96,2,213,211,234,111,167,234,17,133,74,173,255,97,171,2,157,231,189,92,248,186,93,154,119,114,248,148,114,135,41,84,217,82,117,247,154,224,77,247,214,90,3,38,159,123,229,90,24,195,215,194,75,97,12,246,37,144,195,41,64,226,245,41,195,44,83,237,8,246,240,204,21,236,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("265f0b5e-a6be-455d-942d-40f04c0b5236"));
		}

		#endregion

	}

	#endregion

}

