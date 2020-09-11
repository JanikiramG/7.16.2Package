namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysDateTimeFormat

	/// <exclude/>
	public class SysDateTimeFormat : Terrasoft.Configuration.SysDateTimeFormat
	{

		#region Constructors: Public

		public SysDateTimeFormat(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysDateTimeFormat(Terrasoft.Configuration.SysDateTimeFormat source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

