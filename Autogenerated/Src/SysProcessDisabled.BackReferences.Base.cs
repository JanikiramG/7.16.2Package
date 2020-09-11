namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysProcessDisabled

	/// <exclude/>
	public class SysProcessDisabled : Terrasoft.Configuration.SysProcessDisabled
	{

		#region Constructors: Public

		public SysProcessDisabled(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysProcessDisabled(Terrasoft.Configuration.SysProcessDisabled source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

