namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: BaseLczEntity

	/// <exclude/>
	public class BaseLczEntity : Terrasoft.Configuration.BaseLczEntity
	{

		#region Constructors: Public

		public BaseLczEntity(UserConnection userConnection)
			: base(userConnection) {
		}

		public BaseLczEntity(Terrasoft.Configuration.BaseLczEntity source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

