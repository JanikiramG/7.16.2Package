namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysLocalizableValue

	/// <exclude/>
	public class SysLocalizableValue : Terrasoft.Configuration.SysLocalizableValue
	{

		#region Constructors: Public

		public SysLocalizableValue(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysLocalizableValue(Terrasoft.Configuration.SysLocalizableValue source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

