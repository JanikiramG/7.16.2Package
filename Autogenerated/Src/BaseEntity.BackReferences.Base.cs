namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: BaseEntity

	/// <exclude/>
	public class BaseEntity : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public BaseEntity(UserConnection userConnection)
			: base(userConnection) {
		}

		public BaseEntity(Terrasoft.Configuration.BaseEntity source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

