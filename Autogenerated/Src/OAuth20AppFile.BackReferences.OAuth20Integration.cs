namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: OAuth20AppFile

	/// <exclude/>
	public class OAuth20AppFile : Terrasoft.Configuration.OAuth20AppFile
	{

		#region Constructors: Public

		public OAuth20AppFile(UserConnection userConnection)
			: base(userConnection) {
		}

		public OAuth20AppFile(Terrasoft.Configuration.OAuth20AppFile source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

