namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: DuplicatesRuleInFolder

	/// <exclude/>
	public class DuplicatesRuleInFolder : Terrasoft.Configuration.DuplicatesRuleInFolder
	{

		#region Constructors: Public

		public DuplicatesRuleInFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public DuplicatesRuleInFolder(Terrasoft.Configuration.DuplicatesRuleInFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

