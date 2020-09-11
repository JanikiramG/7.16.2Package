namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: OAuth20AppInFolder

	/// <exclude/>
	public class OAuth20AppInFolder : Terrasoft.Configuration.OAuth20AppInFolder
	{

		#region Constructors: Public

		public OAuth20AppInFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public OAuth20AppInFolder(Terrasoft.Configuration.OAuth20AppInFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

