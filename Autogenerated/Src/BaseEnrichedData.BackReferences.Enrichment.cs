namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: BaseEnrichedData

	/// <exclude/>
	public class BaseEnrichedData : Terrasoft.Configuration.BaseEnrichedData
	{

		#region Constructors: Public

		public BaseEnrichedData(UserConnection userConnection)
			: base(userConnection) {
		}

		public BaseEnrichedData(Terrasoft.Configuration.BaseEnrichedData source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

