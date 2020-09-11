namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysTranslationInFolder

	/// <exclude/>
	public class SysTranslationInFolder : Terrasoft.Configuration.SysTranslationInFolder
	{

		#region Constructors: Public

		public SysTranslationInFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysTranslationInFolder(Terrasoft.Configuration.SysTranslationInFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

