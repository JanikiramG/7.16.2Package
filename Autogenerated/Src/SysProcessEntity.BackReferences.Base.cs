namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysProcessEntity

	/// <exclude/>
	public class SysProcessEntity : Terrasoft.Configuration.SysProcessEntity
	{

		#region Constructors: Public

		public SysProcessEntity(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysProcessEntity(Terrasoft.Configuration.SysProcessEntity source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

