namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ITranslationProviderSchema

	/// <exclude/>
	public class ITranslationProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ITranslationProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ITranslationProviderSchema(ITranslationProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cd13a96a-b434-42c3-9a58-2582a3d879ed");
			Name = "ITranslationProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("78785e02-81e9-4a6c-b0c2-c299c97e7bb9");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,84,77,139,219,48,16,61,103,97,255,131,200,94,92,48,246,125,215,53,148,52,20,67,91,150,77,104,207,90,123,146,21,181,165,48,35,133,134,165,255,189,35,41,31,78,234,100,179,208,155,53,243,244,230,205,155,177,180,236,128,86,178,6,49,7,68,73,102,97,179,137,209,11,181,116,40,173,50,58,155,163,212,212,134,239,219,155,215,219,155,145,35,165,151,98,182,33,11,221,195,201,153,239,182,45,212,30,76,217,23,208,128,170,62,96,250,37,16,178,169,182,202,42,32,6,48,228,14,97,201,215,68,165,45,224,130,21,221,139,170,87,251,17,205,90,53,128,1,187,114,207,173,170,133,218,65,207,32,71,175,1,189,167,254,6,246,197,52,116,47,30,195,253,152,204,243,92,20,228,186,78,226,166,220,5,126,162,178,64,194,30,88,179,61,54,63,5,23,43,137,178,19,154,173,252,56,254,5,155,113,249,4,100,28,178,46,62,101,69,30,242,195,240,94,5,182,206,117,250,59,135,199,101,175,29,81,135,120,192,191,147,235,135,108,221,48,217,218,103,142,216,214,70,53,177,237,30,60,33,139,126,112,220,70,42,182,223,131,138,207,103,131,134,15,15,23,188,158,129,223,24,18,245,139,212,75,104,250,20,91,185,20,245,210,181,51,0,191,88,60,134,176,96,111,12,0,65,54,113,47,206,27,37,86,104,106,160,176,195,93,192,254,107,221,19,243,76,98,7,243,83,15,40,152,64,73,212,35,162,188,84,124,10,255,73,17,157,219,57,152,250,173,78,197,103,201,131,80,29,148,226,32,240,162,139,190,254,160,135,61,215,250,125,211,134,38,174,181,14,129,42,189,48,239,55,235,28,254,104,52,23,172,161,228,171,34,91,84,179,189,16,175,163,20,39,194,82,79,51,250,207,86,17,12,239,27,49,51,179,93,233,88,124,242,68,189,13,178,154,133,193,46,190,22,87,217,194,50,6,124,153,121,9,73,53,213,174,3,148,207,45,188,233,209,197,110,167,191,161,118,254,49,147,193,67,86,25,59,142,199,225,86,99,110,92,70,219,175,105,102,126,160,76,226,173,109,189,157,182,59,208,77,124,134,195,249,79,124,243,143,130,28,251,11,88,33,14,59,143,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cd13a96a-b434-42c3-9a58-2582a3d879ed"));
		}

		#endregion

	}

	#endregion

}

