namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwCommandAction

	/// <exclude/>
	public class VwCommandAction : Terrasoft.Configuration.VwCommandAction
	{

		#region Constructors: Public

		public VwCommandAction(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwCommandAction(Terrasoft.Configuration.VwCommandAction source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

