namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwSysSchemaInfo

	/// <exclude/>
	public class VwSysSchemaInfo : Terrasoft.Configuration.VwSysSchemaInfo
	{

		#region Constructors: Public

		public VwSysSchemaInfo(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwSysSchemaInfo(Terrasoft.Configuration.VwSysSchemaInfo source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<EmailTemplate> EmailTemplateCollectionByObject {
			get;
			set;
		}

		public IEnumerable<LandingType> LandingTypeCollectionBySchemaUid {
			get;
			set;
		}

		public IEnumerable<SearchSetting> SearchSettingCollectionBySearchEntity {
			get;
			set;
		}

		public IEnumerable<VwIsolatedRecord> VwIsolatedRecordCollectionByEntitySchema {
			get;
			set;
		}

		public IEnumerable<VwSysLookup> VwSysLookupCollectionBySysEntitySchemaU {
			get;
			set;
		}

		public IEnumerable<VwSysLookup> VwSysLookupCollectionBySysGridPageSchemaU {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

