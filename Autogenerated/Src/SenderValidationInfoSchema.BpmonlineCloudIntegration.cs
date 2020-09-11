namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SenderValidationInfoSchema

	/// <exclude/>
	public class SenderValidationInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SenderValidationInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SenderValidationInfoSchema(SenderValidationInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f6ab86a0-e08a-4fdf-9955-a869f72bbafb");
			Name = "SenderValidationInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,81,193,106,195,48,12,61,55,208,127,16,244,158,220,151,208,75,40,101,176,65,89,74,119,246,18,37,51,56,118,144,156,141,18,246,239,83,156,54,219,10,107,217,78,70,79,122,79,239,89,86,181,200,157,42,17,246,72,164,216,213,62,206,157,173,117,211,147,242,218,217,56,223,20,143,174,66,195,203,104,88,70,139,158,181,109,160,56,178,199,86,38,141,193,114,28,227,120,139,22,73,151,233,50,146,169,21,97,35,40,228,70,49,223,65,129,182,66,58,40,163,171,32,122,111,107,23,230,146,36,129,140,251,182,85,116,92,159,234,39,236,8,25,173,103,144,183,19,109,132,218,17,112,16,129,183,89,37,62,11,36,223,20,186,254,197,232,18,202,113,241,47,123,23,67,216,61,155,220,145,235,144,188,70,113,186,11,244,169,127,105,46,0,91,20,95,193,141,188,254,21,225,157,156,124,8,182,74,27,6,163,217,199,51,55,185,36,103,98,190,199,185,220,223,160,127,77,159,82,61,72,63,99,79,114,130,53,60,143,204,77,32,142,56,12,208,160,79,71,99,41,124,252,37,193,233,71,177,250,127,138,91,18,215,147,28,206,236,235,105,86,114,205,233,100,161,158,208,159,160,96,159,80,220,151,142,210,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f6ab86a0-e08a-4fdf-9955-a869f72bbafb"));
		}

		#endregion

	}

	#endregion

}

