namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: CallInFolder

	/// <exclude/>
	public class CallInFolder : Terrasoft.Configuration.CallInFolder
	{

		#region Constructors: Public

		public CallInFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public CallInFolder(Terrasoft.Configuration.CallInFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

