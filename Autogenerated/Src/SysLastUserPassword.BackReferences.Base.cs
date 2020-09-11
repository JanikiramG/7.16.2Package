namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysLastUserPassword

	/// <exclude/>
	public class SysLastUserPassword : Terrasoft.Configuration.SysLastUserPassword
	{

		#region Constructors: Public

		public SysLastUserPassword(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysLastUserPassword(Terrasoft.Configuration.SysLastUserPassword source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

