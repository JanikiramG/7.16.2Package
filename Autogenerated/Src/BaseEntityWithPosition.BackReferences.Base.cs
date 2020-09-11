namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: BaseEntityWithPosition

	/// <exclude/>
	public class BaseEntityWithPosition : Terrasoft.Configuration.BaseEntityWithPosition
	{

		#region Constructors: Public

		public BaseEntityWithPosition(UserConnection userConnection)
			: base(userConnection) {
		}

		public BaseEntityWithPosition(Terrasoft.Configuration.BaseEntityWithPosition source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

