namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysTranslation

	/// <exclude/>
	public class SysTranslation : Terrasoft.Configuration.SysTranslation
	{

		#region Constructors: Public

		public SysTranslation(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysTranslation(Terrasoft.Configuration.SysTranslation source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SysTranslationInFolder> SysTranslationInFolderCollectionBySysTranslation {
			get;
			set;
		}

		public IEnumerable<SysTranslationInTag> SysTranslationInTagCollectionByEntity {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

