namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: OAuth20AppInTag

	/// <exclude/>
	public class OAuth20AppInTag : Terrasoft.Configuration.OAuth20AppInTag
	{

		#region Constructors: Public

		public OAuth20AppInTag(UserConnection userConnection)
			: base(userConnection) {
		}

		public OAuth20AppInTag(Terrasoft.Configuration.OAuth20AppInTag source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

