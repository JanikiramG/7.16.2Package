namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysUIElementVisibility

	/// <exclude/>
	public class SysUIElementVisibility : Terrasoft.Configuration.SysUIElementVisibility
	{

		#region Constructors: Public

		public SysUIElementVisibility(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysUIElementVisibility(Terrasoft.Configuration.SysUIElementVisibility source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

