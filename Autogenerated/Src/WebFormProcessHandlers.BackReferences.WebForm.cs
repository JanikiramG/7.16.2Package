namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: WebFormProcessHandlers

	/// <exclude/>
	public class WebFormProcessHandlers : Terrasoft.Configuration.WebFormProcessHandlers
	{

		#region Constructors: Public

		public WebFormProcessHandlers(UserConnection userConnection)
			: base(userConnection) {
		}

		public WebFormProcessHandlers(Terrasoft.Configuration.WebFormProcessHandlers source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

