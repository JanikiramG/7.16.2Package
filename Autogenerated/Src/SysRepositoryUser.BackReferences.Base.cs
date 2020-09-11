namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysRepositoryUser

	/// <exclude/>
	public class SysRepositoryUser : Terrasoft.Configuration.SysRepositoryUser
	{

		#region Constructors: Public

		public SysRepositoryUser(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysRepositoryUser(Terrasoft.Configuration.SysRepositoryUser source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

