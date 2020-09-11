namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ISyncStrategyOldSchema

	/// <exclude/>
	public class ISyncStrategyOldSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ISyncStrategyOldSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ISyncStrategyOldSchema(ISyncStrategyOldSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("76b5b400-3766-43fa-9c77-680aa2894dfe");
			Name = "ISyncStrategyOld";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("80eb4b00-d20b-4335-a2cc-1f02c0e63f83");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,213,84,205,142,211,48,16,62,183,82,223,97,84,46,172,180,74,238,187,221,30,224,128,122,8,170,8,60,128,73,38,137,133,99,151,153,73,69,64,251,238,216,113,219,245,182,208,3,7,86,123,137,236,177,253,253,204,231,216,170,30,121,167,42,132,207,72,164,216,53,146,21,74,155,197,252,215,98,62,27,88,219,22,202,145,5,251,251,211,60,172,191,67,204,54,189,218,133,241,229,74,161,123,244,85,95,127,67,216,106,103,97,99,5,169,241,60,119,176,41,71,91,149,66,74,176,29,167,77,121,158,195,138,135,190,87,52,174,15,243,45,185,189,174,145,161,71,233,92,205,208,56,130,22,5,190,15,72,35,136,3,70,69,85,23,104,173,19,96,15,138,181,223,205,172,90,228,236,8,155,39,184,187,225,171,209,21,236,20,137,86,6,244,81,211,185,164,89,240,126,146,94,68,1,119,176,157,142,79,138,47,36,79,133,79,40,3,89,246,11,136,80,17,54,15,203,243,94,101,69,20,184,177,53,254,120,239,140,193,74,60,201,50,95,79,6,143,242,111,129,144,157,217,123,71,138,83,127,71,42,109,161,26,136,208,138,63,103,106,164,236,164,42,63,151,181,242,134,85,15,214,71,253,176,172,140,246,135,150,235,107,26,195,32,40,210,150,69,121,218,108,149,79,16,79,136,20,157,158,10,31,47,19,248,183,46,36,54,82,142,63,239,135,15,40,95,108,228,45,184,157,86,145,223,6,22,136,62,111,238,95,52,174,36,173,24,130,39,57,228,16,83,219,42,233,34,216,255,207,48,69,76,212,172,167,246,197,2,52,131,49,254,127,145,238,245,94,129,91,96,161,240,74,60,121,188,122,43,10,69,223,248,104,33,196,25,192,59,114,86,255,196,250,229,18,234,80,121,245,215,17,195,231,208,166,191,2,239,157,174,161,68,57,236,43,19,115,207,187,150,128,65,36,15,109,155,205,166,167,17,109,29,95,71,63,123,140,15,125,82,90,204,31,127,3,155,154,117,142,88,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("76b5b400-3766-43fa-9c77-680aa2894dfe"));
		}

		#endregion

	}

	#endregion

}

