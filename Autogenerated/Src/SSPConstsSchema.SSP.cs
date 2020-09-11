namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SSPConstsSchema

	/// <exclude/>
	public class SSPConstsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SSPConstsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SSPConstsSchema(SSPConstsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("baddafff-9580-40c5-a726-cdd52e87d9ee");
			Name = "SSPConsts";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("39b1aa09-c30c-47e9-9379-18a9c48e3a0f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,144,189,106,195,48,20,70,103,27,252,14,151,76,237,160,164,216,114,156,16,58,248,71,46,217,66,157,23,80,45,217,8,108,201,72,114,130,9,125,247,202,109,104,200,210,37,133,187,232,234,211,249,14,26,141,144,45,84,147,177,188,223,5,126,224,75,218,115,51,208,154,195,145,107,77,141,106,236,50,87,178,17,237,168,169,21,74,6,254,37,240,189,97,252,232,68,13,198,186,93,13,117,71,141,129,170,58,184,164,177,198,221,95,102,150,231,173,86,240,206,91,97,236,207,91,224,61,21,29,184,174,161,163,150,131,96,92,90,209,8,174,151,115,250,30,170,57,101,74,118,19,188,141,130,221,97,200,76,57,94,33,123,6,175,32,249,249,59,246,180,72,227,162,32,56,95,163,164,136,182,8,39,225,11,74,83,119,220,16,146,100,209,154,164,101,150,46,158,119,191,114,189,144,12,6,167,127,86,154,61,228,87,171,19,215,211,225,138,250,203,17,227,60,79,55,25,70,241,182,8,17,38,36,66,25,137,49,42,112,82,146,114,157,71,73,152,221,28,247,242,36,236,163,223,119,131,252,139,152,171,251,12,124,55,95,116,35,228,202,64,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("baddafff-9580-40c5-a726-cdd52e87d9ee"));
		}

		#endregion

	}

	#endregion

}

