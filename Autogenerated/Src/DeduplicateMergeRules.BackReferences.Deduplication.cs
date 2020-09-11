namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: DeduplicateMergeRules

	/// <exclude/>
	public class DeduplicateMergeRules : Terrasoft.Configuration.DeduplicateMergeRules
	{

		#region Constructors: Public

		public DeduplicateMergeRules(UserConnection userConnection)
			: base(userConnection) {
		}

		public DeduplicateMergeRules(Terrasoft.Configuration.DeduplicateMergeRules source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

