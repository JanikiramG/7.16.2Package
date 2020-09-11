namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ExternalAccessInTag

	/// <exclude/>
	public class ExternalAccessInTag : Terrasoft.Configuration.ExternalAccessInTag
	{

		#region Constructors: Public

		public ExternalAccessInTag(UserConnection userConnection)
			: base(userConnection) {
		}

		public ExternalAccessInTag(Terrasoft.Configuration.ExternalAccessInTag source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

