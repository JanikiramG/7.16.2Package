namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysEditPage

	/// <exclude/>
	public class SysEditPage : Terrasoft.Configuration.SysEditPage
	{

		#region Constructors: Public

		public SysEditPage(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysEditPage(Terrasoft.Configuration.SysEditPage source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

