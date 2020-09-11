namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: CallFolder

	/// <exclude/>
	public class CallFolder : Terrasoft.Configuration.CallFolder
	{

		#region Constructors: Public

		public CallFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public CallFolder(Terrasoft.Configuration.CallFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<CallFolder> CallFolderCollectionByParent {
			get;
			set;
		}

		public IEnumerable<CallInFolder> CallInFolderCollectionByFolder {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

