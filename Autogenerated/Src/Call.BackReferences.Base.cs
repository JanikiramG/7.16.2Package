namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: Call

	/// <exclude/>
	public class Call : Terrasoft.Configuration.Call
	{

		#region Constructors: Public

		public Call(UserConnection userConnection)
			: base(userConnection) {
		}

		public Call(Terrasoft.Configuration.Call source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<CallFile> CallFileCollectionByCall {
			get;
			set;
		}

		public IEnumerable<CallInFolder> CallInFolderCollectionByCall {
			get;
			set;
		}

		public IEnumerable<CallInTag> CallInTagCollectionByEntity {
			get;
			set;
		}

		public IEnumerable<SysActiveCall> SysActiveCallCollectionByCall {
			get;
			set;
		}

		public IEnumerable<SysActiveCall> SysActiveCallCollectionByParentCall {
			get;
			set;
		}

		public IEnumerable<VwRecentCall> VwRecentCallCollectionByCall {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

