namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LeadMLangBinderSchema

	/// <exclude/>
	public class LeadMLangBinderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LeadMLangBinderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LeadMLangBinderSchema(LeadMLangBinderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f319c644-f47a-4da7-b6eb-96ccd3799545");
			Name = "LeadMLangBinder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("df5a8bee-e0f6-4225-b7c8-127f6fd1b1ca");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,81,193,106,195,48,12,61,183,208,127,16,221,165,131,145,220,219,82,88,203,6,133,148,13,54,216,217,137,213,204,16,219,193,150,195,74,233,191,79,177,147,209,150,157,140,244,158,158,222,147,141,208,232,91,81,33,124,162,115,194,219,35,101,59,107,142,170,14,78,144,178,102,54,61,207,166,147,224,149,169,111,40,14,179,87,81,145,117,10,253,234,31,198,23,150,204,210,218,26,70,25,127,112,88,179,28,236,26,225,253,18,10,20,242,80,8,83,111,149,145,232,34,37,207,115,88,251,160,181,112,167,205,80,247,60,208,161,33,213,48,57,136,26,161,234,21,160,140,115,217,56,150,95,205,181,161,108,84,53,240,238,22,193,18,158,219,246,165,67,67,133,242,132,6,221,86,120,228,169,115,244,240,231,243,128,244,109,37,59,125,143,106,9,28,148,109,199,49,149,68,232,172,146,240,102,88,241,131,132,163,197,40,205,23,36,252,33,168,210,251,8,253,13,39,147,146,55,101,87,244,17,94,69,52,94,38,221,244,148,245,110,215,251,98,200,188,39,228,223,176,238,41,198,185,239,110,22,243,190,61,79,58,151,33,7,26,153,162,196,58,117,111,155,151,95,226,87,84,248,253,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f319c644-f47a-4da7-b6eb-96ccd3799545"));
		}

		#endregion

	}

	#endregion

}

