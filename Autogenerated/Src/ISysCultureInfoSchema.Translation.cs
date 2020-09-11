namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ISysCultureInfoSchema

	/// <exclude/>
	public class ISysCultureInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ISysCultureInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ISysCultureInfoSchema(ISysCultureInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ea1fdfd0-6ef8-44d6-b478-24f2418a19b8");
			Name = "ISysCultureInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6d2d1275-178c-4cc9-a265-eb797a3ca54a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,81,77,107,195,48,12,61,39,144,255,32,232,61,185,183,99,151,28,70,46,163,176,178,187,23,203,158,33,145,131,108,195,74,217,127,159,226,172,37,99,148,146,155,252,244,62,44,137,212,136,97,82,61,194,9,153,85,240,38,214,173,39,227,108,98,21,157,167,250,196,138,194,144,235,170,188,84,101,145,130,35,11,111,231,16,113,60,84,165,32,59,70,43,109,232,40,34,27,49,219,67,39,253,54,13,49,49,118,100,124,166,77,233,99,112,61,184,43,235,63,169,184,100,226,205,240,200,126,66,142,14,195,30,142,89,189,244,155,166,129,167,144,198,81,241,249,249,10,44,63,130,126,49,4,167,145,162,51,14,185,190,73,154,181,230,37,57,13,157,134,121,166,162,176,24,15,115,241,189,33,129,52,126,221,49,151,33,101,29,210,223,96,191,218,52,244,126,72,35,1,201,121,238,36,132,200,243,29,86,162,54,107,94,69,178,33,244,29,89,150,212,111,76,93,171,30,197,254,74,186,208,126,42,178,168,31,241,119,72,122,185,127,126,47,232,95,80,176,31,48,204,186,108,185,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ea1fdfd0-6ef8-44d6-b478-24f2418a19b8"));
		}

		#endregion

	}

	#endregion

}

