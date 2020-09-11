namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ShowNamesBy

	/// <exclude/>
	public class ShowNamesBy : Terrasoft.Configuration.ShowNamesBy
	{

		#region Constructors: Public

		public ShowNamesBy(UserConnection userConnection)
			: base(userConnection) {
		}

		public ShowNamesBy(Terrasoft.Configuration.ShowNamesBy source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

