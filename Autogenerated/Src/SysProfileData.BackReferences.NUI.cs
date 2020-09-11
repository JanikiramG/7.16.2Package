namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysProfileData

	/// <exclude/>
	public class SysProfileData : Terrasoft.Configuration.SysProfileData
	{

		#region Constructors: Public

		public SysProfileData(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysProfileData(Terrasoft.Configuration.SysProfileData source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

