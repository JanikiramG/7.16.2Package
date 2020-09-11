namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysTranslationInTag

	/// <exclude/>
	public class SysTranslationInTag : Terrasoft.Configuration.SysTranslationInTag
	{

		#region Constructors: Public

		public SysTranslationInTag(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysTranslationInTag(Terrasoft.Configuration.SysTranslationInTag source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

