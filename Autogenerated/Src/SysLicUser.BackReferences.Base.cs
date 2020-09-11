namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysLicUser

	/// <exclude/>
	public class SysLicUser : Terrasoft.Configuration.SysLicUser
	{

		#region Constructors: Public

		public SysLicUser(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysLicUser(Terrasoft.Configuration.SysLicUser source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

