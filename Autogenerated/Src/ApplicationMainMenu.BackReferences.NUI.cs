namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ApplicationMainMenu

	/// <exclude/>
	public class ApplicationMainMenu : Terrasoft.Configuration.ApplicationMainMenu
	{

		#region Constructors: Public

		public ApplicationMainMenu(UserConnection userConnection)
			: base(userConnection) {
		}

		public ApplicationMainMenu(Terrasoft.Configuration.ApplicationMainMenu source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

