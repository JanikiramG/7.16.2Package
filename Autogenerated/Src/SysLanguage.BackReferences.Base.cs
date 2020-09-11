namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysLanguage

	/// <exclude/>
	public class SysLanguage : Terrasoft.Configuration.SysLanguage
	{

		#region Constructors: Public

		public SysLanguage(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysLanguage(Terrasoft.Configuration.SysLanguage source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Contact> ContactCollectionByLanguage {
			get;
			set;
		}

		public IEnumerable<EmailTemplateLang> EmailTemplateLangCollectionByLanguage {
			get;
			set;
		}

		public IEnumerable<SysAdminUnit> SysAdminUnitCollectionByDateTimeFormat {
			get;
			set;
		}

		public IEnumerable<SysCulture> SysCultureCollectionByLanguage {
			get;
			set;
		}

		public IEnumerable<VwSysAdminUnit> VwSysAdminUnitCollectionByDateTimeFormat {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

