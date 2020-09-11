namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysTranslationTag

	/// <exclude/>
	public class SysTranslationTag : Terrasoft.Configuration.SysTranslationTag
	{

		#region Constructors: Public

		public SysTranslationTag(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysTranslationTag(Terrasoft.Configuration.SysTranslationTag source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SysTranslationInTag> SysTranslationInTagCollectionByTag {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

