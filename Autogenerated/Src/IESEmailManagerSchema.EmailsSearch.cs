namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IESEmailManagerSchema

	/// <exclude/>
	public class IESEmailManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IESEmailManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IESEmailManagerSchema(IESEmailManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0f0a3bfc-dd1a-49ca-91a0-daff393823fe");
			Name = "IESEmailManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("92df5372-6a61-42f2-95f4-67c9e246a93f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,144,193,106,195,48,12,134,207,14,228,29,4,189,108,48,242,0,109,201,101,11,37,176,194,32,123,1,197,85,82,131,99,119,146,125,40,165,239,94,215,94,7,99,236,96,132,237,207,191,62,203,225,66,114,66,77,240,73,204,40,126,10,205,171,119,147,153,35,99,48,222,53,221,130,198,202,64,200,250,88,87,151,186,170,43,21,197,184,25,134,179,4,90,18,110,45,233,59,43,205,142,28,177,209,155,31,230,191,212,157,245,35,218,146,186,201,153,43,166,57,221,64,239,2,241,148,140,214,208,119,67,238,190,71,135,51,113,198,78,113,180,70,131,121,80,127,33,149,28,149,186,175,71,228,158,194,209,31,100,13,31,249,113,206,81,125,231,226,66,140,163,165,237,155,201,254,200,231,173,4,78,222,47,80,106,219,66,113,44,83,120,122,55,18,190,145,22,152,190,34,73,120,46,254,106,69,238,80,26,230,253,181,252,234,215,225,245,6,250,32,23,12,111,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0f0a3bfc-dd1a-49ca-91a0-daff393823fe"));
		}

		#endregion

	}

	#endregion

}

