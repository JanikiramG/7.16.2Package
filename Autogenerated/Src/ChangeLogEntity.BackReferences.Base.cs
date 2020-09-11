namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ChangeLogEntity

	/// <exclude/>
	public class ChangeLogEntity : Terrasoft.Configuration.ChangeLogEntity
	{

		#region Constructors: Public

		public ChangeLogEntity(UserConnection userConnection)
			: base(userConnection) {
		}

		public ChangeLogEntity(Terrasoft.Configuration.ChangeLogEntity source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

