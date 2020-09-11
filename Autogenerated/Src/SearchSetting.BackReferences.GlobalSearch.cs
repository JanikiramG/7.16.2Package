namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SearchSetting

	/// <exclude/>
	public class SearchSetting : Terrasoft.Configuration.SearchSetting
	{

		#region Constructors: Public

		public SearchSetting(UserConnection userConnection)
			: base(userConnection) {
		}

		public SearchSetting(Terrasoft.Configuration.SearchSetting source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

