namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OpportunityLanguageIteratorSchema

	/// <exclude/>
	public class OpportunityLanguageIteratorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OpportunityLanguageIteratorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OpportunityLanguageIteratorSchema(OpportunityLanguageIteratorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("561424eb-006b-4c14-a174-a6cb826ea99f");
			Name = "OpportunityLanguageIterator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0e987dc8-e3a7-4136-b3d3-af8a5676bbce");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,146,77,107,195,48,12,134,207,41,244,63,136,236,210,66,73,238,253,130,173,187,20,6,27,99,61,141,29,84,79,9,134,196,14,254,96,116,165,255,125,138,147,174,73,86,186,67,8,150,94,61,122,37,91,97,73,182,66,65,240,70,198,160,213,153,75,54,90,101,50,247,6,157,212,106,60,58,142,71,145,183,82,229,61,137,161,197,120,196,153,59,67,57,203,96,83,160,181,115,120,174,42,109,156,87,210,29,158,80,229,30,115,218,58,98,148,54,65,158,166,41,44,173,47,75,52,135,117,123,62,11,32,227,175,144,214,213,189,246,7,208,23,22,20,45,204,38,103,72,218,161,84,126,95,72,1,162,246,112,203,2,204,225,1,45,253,117,22,29,131,187,203,52,90,89,103,188,224,36,15,245,18,240,141,98,56,64,51,1,55,147,88,200,111,178,160,232,11,36,87,163,226,165,234,140,197,68,32,12,101,171,248,134,179,56,93,39,240,203,79,135,13,150,21,26,44,65,241,109,173,98,111,201,176,65,69,162,190,160,120,189,227,51,136,223,64,178,76,131,58,20,183,155,185,209,121,178,235,225,160,79,159,214,144,104,14,123,94,219,100,144,130,99,72,158,129,175,190,224,241,87,97,1,219,110,240,253,163,85,70,117,234,145,50,244,133,99,142,67,225,186,186,129,147,25,116,23,22,79,103,23,70,91,188,85,247,66,104,175,220,149,241,174,0,187,132,214,197,255,234,211,162,254,157,218,231,65,234,179,121,33,225,220,68,251,193,211,15,245,37,224,207,82,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("561424eb-006b-4c14-a174-a6cb826ea99f"));
		}

		#endregion

	}

	#endregion

}

