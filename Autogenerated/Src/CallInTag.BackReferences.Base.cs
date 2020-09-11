namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: CallInTag

	/// <exclude/>
	public class CallInTag : Terrasoft.Configuration.CallInTag
	{

		#region Constructors: Public

		public CallInTag(UserConnection userConnection)
			: base(userConnection) {
		}

		public CallInTag(Terrasoft.Configuration.CallInTag source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

