namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwPageTemplate

	/// <exclude/>
	public class VwPageTemplate : Terrasoft.Configuration.VwPageTemplate
	{

		#region Constructors: Public

		public VwPageTemplate(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwPageTemplate(Terrasoft.Configuration.VwPageTemplate source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

