namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysStartTimerType

	/// <exclude/>
	public class SysStartTimerType : Terrasoft.Configuration.SysStartTimerType
	{

		#region Constructors: Public

		public SysStartTimerType(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysStartTimerType(Terrasoft.Configuration.SysStartTimerType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

