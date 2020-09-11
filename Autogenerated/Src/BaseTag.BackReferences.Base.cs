namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: BaseTag

	/// <exclude/>
	public class BaseTag : Terrasoft.Configuration.BaseTag
	{

		#region Constructors: Public

		public BaseTag(UserConnection userConnection)
			: base(userConnection) {
		}

		public BaseTag(Terrasoft.Configuration.BaseTag source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

