namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysActiveCall

	/// <exclude/>
	public class SysActiveCall : Terrasoft.Configuration.SysActiveCall
	{

		#region Constructors: Public

		public SysActiveCall(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysActiveCall(Terrasoft.Configuration.SysActiveCall source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

