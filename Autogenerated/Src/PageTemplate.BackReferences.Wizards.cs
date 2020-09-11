namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: PageTemplate

	/// <exclude/>
	public class PageTemplate : Terrasoft.Configuration.PageTemplate
	{

		#region Constructors: Public

		public PageTemplate(UserConnection userConnection)
			: base(userConnection) {
		}

		public PageTemplate(Terrasoft.Configuration.PageTemplate source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

