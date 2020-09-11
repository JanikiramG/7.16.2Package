namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysPrcEntityHistory

	/// <exclude/>
	public class SysPrcEntityHistory : Terrasoft.Configuration.SysPrcEntityHistory
	{

		#region Constructors: Public

		public SysPrcEntityHistory(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysPrcEntityHistory(Terrasoft.Configuration.SysPrcEntityHistory source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

