namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: EntityInForecastCell

	/// <exclude/>
	public class EntityInForecastCell : Terrasoft.Configuration.EntityInForecastCell
	{

		#region Constructors: Public

		public EntityInForecastCell(UserConnection userConnection)
			: base(userConnection) {
		}

		public EntityInForecastCell(Terrasoft.Configuration.EntityInForecastCell source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

