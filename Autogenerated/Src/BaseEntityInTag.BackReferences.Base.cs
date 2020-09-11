namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: BaseEntityInTag

	/// <exclude/>
	public class BaseEntityInTag : Terrasoft.Configuration.BaseEntityInTag
	{

		#region Constructors: Public

		public BaseEntityInTag(UserConnection userConnection)
			: base(userConnection) {
		}

		public BaseEntityInTag(Terrasoft.Configuration.BaseEntityInTag source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

