namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysRegistrationData

	/// <exclude/>
	public class SysRegistrationData : Terrasoft.Configuration.SysRegistrationData
	{

		#region Constructors: Public

		public SysRegistrationData(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysRegistrationData(Terrasoft.Configuration.SysRegistrationData source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

