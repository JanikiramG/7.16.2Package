namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: Favorites

	/// <exclude/>
	public class Favorites : Terrasoft.Configuration.Favorites
	{

		#region Constructors: Public

		public Favorites(UserConnection userConnection)
			: base(userConnection) {
		}

		public Favorites(Terrasoft.Configuration.Favorites source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

