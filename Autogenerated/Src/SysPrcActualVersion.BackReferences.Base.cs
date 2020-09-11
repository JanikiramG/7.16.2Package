namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysPrcActualVersion

	/// <exclude/>
	public class SysPrcActualVersion : Terrasoft.Configuration.SysPrcActualVersion
	{

		#region Constructors: Public

		public SysPrcActualVersion(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysPrcActualVersion(Terrasoft.Configuration.SysPrcActualVersion source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

