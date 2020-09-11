namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IPriceListPickerSchema

	/// <exclude/>
	public class IPriceListPickerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IPriceListPickerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IPriceListPickerSchema(IPriceListPickerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("664fa71d-95dd-488e-ad10-f92c9b477801");
			Name = "IPriceListPicker";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c797525-d05e-4bd8-84e9-5dcb79ad7c60");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,144,65,106,195,48,16,69,215,49,248,14,67,86,237,198,58,64,93,67,233,34,24,186,8,180,23,80,229,81,24,106,141,204,104,180,8,37,119,175,229,36,162,180,59,233,207,127,243,63,195,54,96,90,172,67,248,64,17,155,162,215,238,53,178,167,83,22,171,20,185,109,190,219,102,151,19,241,9,222,207,73,49,60,181,205,170,24,99,160,79,57,4,43,231,225,246,31,89,81,124,89,230,163,192,81,200,225,27,37,133,132,51,186,178,172,187,131,230,23,185,228,207,153,28,80,133,199,74,30,201,125,161,172,158,210,225,95,228,38,28,80,97,41,254,185,36,93,123,90,231,98,102,237,42,100,254,82,155,186,88,177,1,120,189,192,243,254,134,140,211,126,120,185,62,129,38,100,37,79,40,93,111,54,111,197,123,65,205,194,105,168,77,123,115,151,138,231,144,105,42,205,234,248,97,83,106,200,227,122,195,221,165,109,46,63,47,166,44,173,127,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("664fa71d-95dd-488e-ad10-f92c9b477801"));
		}

		#endregion

	}

	#endregion

}

