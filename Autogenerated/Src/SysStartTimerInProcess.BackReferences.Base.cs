namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysStartTimerInProcess

	/// <exclude/>
	public class SysStartTimerInProcess : Terrasoft.Configuration.SysStartTimerInProcess
	{

		#region Constructors: Public

		public SysStartTimerInProcess(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysStartTimerInProcess(Terrasoft.Configuration.SysStartTimerInProcess source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

