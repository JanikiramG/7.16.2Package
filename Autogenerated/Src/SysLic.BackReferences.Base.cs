namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysLic

	/// <exclude/>
	public class SysLic : Terrasoft.Configuration.SysLic
	{

		#region Constructors: Public

		public SysLic(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysLic(Terrasoft.Configuration.SysLic source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

