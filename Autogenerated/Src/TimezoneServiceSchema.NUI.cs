namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TimezoneServiceSchema

	/// <exclude/>
	public class TimezoneServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TimezoneServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TimezoneServiceSchema(TimezoneServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f1a2599c-253b-44c3-99dd-8d8331d75b10");
			Name = "TimezoneService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("edbaf284-b37c-4101-84cb-76a44645334f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,221,83,193,110,219,48,12,61,187,64,255,65,200,201,1,2,127,192,186,12,72,13,52,203,128,44,67,156,161,135,160,7,197,98,51,109,182,228,73,84,6,111,232,191,143,116,236,52,246,130,236,180,203,142,36,31,201,199,247,36,35,75,240,149,204,65,108,192,57,233,237,51,38,169,53,207,122,31,156,68,109,205,237,205,175,219,155,40,120,109,246,34,171,61,66,121,55,136,147,12,220,65,231,176,180,10,138,171,197,100,150,163,62,52,99,175,227,30,97,247,7,128,114,4,242,158,154,51,148,8,175,128,115,230,14,146,7,153,163,117,26,252,37,4,79,73,109,89,54,12,168,190,109,247,210,205,232,168,241,137,115,51,95,125,4,36,88,69,92,119,186,208,88,175,225,123,208,14,74,48,232,227,243,128,9,139,169,248,75,11,163,146,54,161,198,188,164,10,187,66,231,34,47,164,247,98,163,75,248,105,13,180,100,196,27,113,47,125,23,77,196,98,13,82,173,76,81,159,223,79,51,216,153,168,114,44,41,156,102,188,135,162,2,39,230,128,253,76,60,22,13,62,90,240,173,116,106,87,22,249,32,158,138,148,89,29,117,172,19,154,244,118,208,242,46,110,38,69,6,126,8,42,121,116,129,177,51,183,15,124,110,60,10,30,28,21,12,228,108,246,104,34,62,247,18,227,241,93,51,192,1,6,103,4,143,25,144,237,227,39,67,142,199,254,151,198,194,104,187,162,142,230,85,157,187,24,109,201,235,133,57,216,111,16,47,1,191,88,69,135,141,62,173,178,13,209,97,43,192,227,131,117,165,68,202,19,116,73,218,202,61,28,83,201,7,207,91,239,173,170,51,172,11,232,65,78,217,228,209,201,170,2,53,225,117,107,250,71,36,5,92,159,217,120,223,153,79,186,241,235,156,243,195,105,206,75,131,115,164,31,95,25,183,197,246,240,133,234,236,27,248,140,253,112,122,201,248,158,216,253,134,228,242,114,118,100,30,180,138,95,215,255,111,146,207,212,215,224,145,159,235,58,20,39,185,59,117,82,250,176,255,78,241,193,238,222,210,78,230,163,212,47,191,1,127,106,114,245,161,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f1a2599c-253b-44c3-99dd-8d8331d75b10"));
		}

		#endregion

	}

	#endregion

}

