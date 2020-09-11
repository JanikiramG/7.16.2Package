namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: BaseEntityInStage

	/// <exclude/>
	public class BaseEntityInStage : Terrasoft.Configuration.BaseEntityInStage
	{

		#region Constructors: Public

		public BaseEntityInStage(UserConnection userConnection)
			: base(userConnection) {
		}

		public BaseEntityInStage(Terrasoft.Configuration.BaseEntityInStage source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

