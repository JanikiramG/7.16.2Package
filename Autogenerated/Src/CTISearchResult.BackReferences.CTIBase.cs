namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: CTISearchResult

	/// <exclude/>
	public class CTISearchResult : Terrasoft.Configuration.CTISearchResult
	{

		#region Constructors: Public

		public CTISearchResult(UserConnection userConnection)
			: base(userConnection) {
		}

		public CTISearchResult(Terrasoft.Configuration.CTISearchResult source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

