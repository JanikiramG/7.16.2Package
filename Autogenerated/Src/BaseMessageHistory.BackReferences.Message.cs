namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: BaseMessageHistory

	/// <exclude/>
	public class BaseMessageHistory : Terrasoft.Configuration.BaseMessageHistory
	{

		#region Constructors: Public

		public BaseMessageHistory(UserConnection userConnection)
			: base(userConnection) {
		}

		public BaseMessageHistory(Terrasoft.Configuration.BaseMessageHistory source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

