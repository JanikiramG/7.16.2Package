namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: CallTag

	/// <exclude/>
	public class CallTag : Terrasoft.Configuration.CallTag
	{

		#region Constructors: Public

		public CallTag(UserConnection userConnection)
			: base(userConnection) {
		}

		public CallTag(Terrasoft.Configuration.CallTag source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<CallInTag> CallInTagCollectionByTag {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

