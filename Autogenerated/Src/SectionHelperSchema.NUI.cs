namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SectionHelperSchema

	/// <exclude/>
	public class SectionHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SectionHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SectionHelperSchema(SectionHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("33d4e612-facc-4d4c-9516-d0f60d673446");
			Name = "SectionHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9defff70-969f-468c-8263-69f6e8af1009");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,81,205,110,194,48,12,62,23,137,119,136,196,5,46,125,0,216,118,24,221,216,14,155,38,21,30,32,11,166,141,148,38,149,237,76,67,104,239,190,52,69,26,133,133,43,82,46,254,108,127,63,142,149,13,80,43,21,136,53,32,74,114,59,206,151,206,238,116,229,81,178,118,118,60,58,140,71,153,39,109,43,81,238,137,161,89,156,213,249,26,190,249,2,92,58,99,64,117,12,148,175,192,2,106,117,49,83,72,150,127,224,169,129,166,113,246,255,14,66,10,207,159,44,107,214,64,201,129,103,169,216,97,98,226,221,235,228,98,241,24,90,161,217,250,79,163,149,80,70,18,137,178,143,247,2,166,5,156,139,215,65,45,14,113,33,155,32,84,1,20,111,192,181,219,210,92,124,68,138,190,121,164,35,198,78,115,5,60,184,124,169,80,183,60,221,16,96,192,109,207,46,252,160,156,117,58,89,150,125,73,20,117,47,124,47,150,157,189,62,235,62,220,158,239,134,180,167,54,31,166,179,69,36,64,96,143,246,200,145,39,172,156,105,199,205,159,84,20,163,193,242,198,106,46,85,13,141,44,128,34,137,67,186,89,164,43,150,174,68,155,128,221,246,191,24,235,128,134,247,11,13,139,216,82,56,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("33d4e612-facc-4d4c-9516-d0f60d673446"));
		}

		#endregion

	}

	#endregion

}

