﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UidBasedSyncStrategySchema

	/// <exclude/>
	public class UidBasedSyncStrategySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UidBasedSyncStrategySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UidBasedSyncStrategySchema(UidBasedSyncStrategySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("91e24315-bb31-4f7d-bc57-72279352dfbb");
			Name = "UidBasedSyncStrategy";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,86,77,111,227,54,16,61,123,129,253,15,3,245,34,23,134,188,5,182,135,38,177,129,38,113,2,3,235,221,20,78,218,67,81,20,180,52,178,137,82,164,66,82,217,184,217,252,247,14,69,201,145,101,201,245,222,164,225,204,240,205,155,15,142,100,25,154,156,197,8,247,168,53,51,42,181,209,130,113,241,254,221,203,251,119,131,194,112,185,134,229,214,88,204,206,91,255,209,149,18,2,99,203,149,52,209,45,74,212,60,62,208,185,21,106,197,4,255,151,57,181,131,211,79,92,62,190,9,223,0,92,169,44,107,170,55,79,100,202,215,133,110,249,107,42,104,236,147,71,215,151,189,71,51,105,185,229,104,122,21,110,88,108,149,246,26,164,243,131,198,53,65,128,43,193,140,57,131,7,158,92,50,131,201,114,43,227,165,37,120,184,222,150,122,227,241,24,46,76,145,101,76,111,167,187,127,68,136,53,166,147,96,222,52,8,198,83,224,89,46,48,67,105,41,66,171,228,8,18,20,252,9,53,38,144,106,149,53,109,175,201,200,95,74,234,75,46,99,108,57,139,234,251,198,109,0,26,233,247,31,83,255,119,161,135,130,4,96,21,24,116,89,6,38,4,72,252,10,84,46,134,173,209,140,42,219,21,241,32,165,35,140,145,18,152,28,99,158,114,50,45,36,127,44,16,120,66,232,156,68,215,166,17,232,52,254,248,243,199,95,96,99,109,110,206,198,99,171,148,48,17,71,155,70,74,175,199,27,155,137,113,165,179,11,161,1,249,207,107,76,89,33,236,37,151,9,93,28,218,109,142,42,13,247,184,28,142,224,51,149,54,76,32,232,138,46,24,254,69,142,242,98,37,120,12,57,211,150,51,1,177,203,101,55,25,103,112,156,109,114,246,82,230,123,87,24,55,28,69,66,149,113,167,149,37,254,48,241,199,237,122,240,252,19,85,188,139,42,3,92,66,70,237,184,82,207,144,42,145,160,142,118,94,154,89,29,228,245,53,96,172,118,217,184,42,180,38,119,11,239,136,130,154,203,155,210,193,121,133,19,101,226,161,238,227,38,188,57,106,187,61,13,249,18,153,142,55,128,207,185,166,139,156,61,245,117,46,136,19,130,171,65,73,177,133,135,121,114,42,104,130,249,133,76,126,43,80,111,97,50,165,220,205,175,225,229,195,235,217,143,193,105,176,169,63,9,120,153,214,35,168,43,110,154,205,180,240,36,123,138,12,117,60,197,147,43,73,25,137,177,236,75,105,44,163,239,190,72,124,37,29,243,82,223,234,15,91,103,110,216,14,6,107,180,231,229,135,169,62,94,143,7,77,211,144,136,43,220,96,58,41,108,141,148,24,83,182,113,35,244,206,254,248,255,144,75,9,181,14,203,64,82,167,77,2,26,24,20,150,148,254,77,8,166,238,31,222,4,209,197,184,212,238,54,54,238,114,180,150,170,192,4,211,195,196,44,155,231,77,112,77,175,85,22,186,2,10,31,246,208,193,62,216,17,148,243,127,11,77,24,195,50,21,103,176,34,95,97,91,127,79,177,74,95,19,35,13,158,166,138,79,107,11,195,164,133,226,148,148,47,208,110,148,159,43,252,137,34,59,146,238,91,180,166,127,10,151,163,229,232,72,57,200,81,246,150,10,83,197,53,79,130,233,195,225,21,213,196,114,12,108,180,146,213,251,15,181,213,241,82,72,185,176,142,22,81,100,242,142,217,77,48,93,236,77,64,3,241,126,243,176,132,59,247,52,193,189,41,157,59,91,154,235,118,115,250,85,191,51,81,224,247,223,245,228,204,14,111,209,104,11,45,77,23,57,135,252,187,215,205,171,251,169,88,102,182,158,137,46,141,135,83,60,188,45,120,2,157,25,25,213,150,109,34,59,15,202,176,119,21,236,223,250,42,246,234,111,82,30,13,220,212,240,146,86,47,13,163,123,149,135,63,249,118,25,12,34,239,55,164,217,157,4,149,48,186,161,221,37,60,62,100,107,213,63,54,180,237,236,116,157,143,104,110,102,143,5,19,161,247,28,221,57,170,145,34,8,59,227,31,214,158,126,149,73,216,230,224,136,179,67,86,134,192,76,21,179,111,96,159,166,125,126,162,217,51,198,133,197,101,204,4,211,23,158,226,105,56,252,190,110,238,155,221,125,187,34,109,220,246,65,186,6,91,152,181,127,133,203,87,147,102,99,231,203,164,104,135,212,84,133,141,170,234,50,15,235,74,224,41,132,94,149,8,251,92,8,241,69,207,178,220,110,195,222,189,98,8,223,190,245,111,29,48,161,77,236,67,80,187,31,184,117,234,158,211,130,38,20,75,102,46,143,198,213,136,19,211,92,252,68,194,250,247,158,182,59,23,237,188,154,248,7,213,71,103,77,253,176,57,134,125,22,118,137,171,34,186,81,58,99,84,198,29,4,140,58,0,81,125,47,75,195,240,111,158,177,220,137,188,135,17,197,43,200,49,206,101,170,162,185,124,98,154,51,105,43,225,176,186,252,181,89,58,45,4,141,125,103,212,79,94,111,45,85,178,166,136,36,255,1,210,107,43,14,212,13,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateFolderNotExistLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateFolderNotExistLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("8135495b-51a3-4ff3-b66e-bef258f69de9"),
				Name = "FolderNotExist",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("91e24315-bb31-4f7d-bc57-72279352dfbb"),
				ModifiedInSchemaUId = new Guid("91e24315-bb31-4f7d-bc57-72279352dfbb")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("91e24315-bb31-4f7d-bc57-72279352dfbb"));
		}

		#endregion

	}

	#endregion

}

