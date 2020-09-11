namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysLookup

	/// <exclude/>
	public class SysLookup : Terrasoft.Configuration.SysLookup
	{

		#region Constructors: Public

		public SysLookup(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysLookup(Terrasoft.Configuration.SysLookup source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<ContentBuilderCustomerFont> ContentBuilderCustomerFontCollectionBySysLookup {
			get;
			set;
		}

		public IEnumerable<ContentBuilderFontSet> ContentBuilderFontSetCollectionBySysLookup {
			get;
			set;
		}

		public IEnumerable<DeduplicateOperation> DeduplicateOperationCollectionBySysLookup {
			get;
			set;
		}

		public IEnumerable<FileSecurityMode> FileSecurityModeCollectionBySysLookup {
			get;
			set;
		}

		public IEnumerable<Lookup> LookupCollectionBySysLookup {
			get;
			set;
		}

		public IEnumerable<RuleRelationSections> RuleRelationSectionsCollectionBySysLookup {
			get;
			set;
		}

		public IEnumerable<SysLookupColumn> SysLookupColumnCollectionBySysLookup {
			get;
			set;
		}

		public IEnumerable<SysLookupSearchColumn> SysLookupSearchColumnCollectionBySysLookup {
			get;
			set;
		}

		public IEnumerable<VwSysLookupInFolder> VwSysLookupInFolderCollectionByVwSysLookup {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

