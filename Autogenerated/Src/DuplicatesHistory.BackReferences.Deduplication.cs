namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: DuplicatesHistory

	/// <exclude/>
	public class DuplicatesHistory : Terrasoft.Configuration.DuplicatesHistory
	{

		#region Constructors: Public

		public DuplicatesHistory(UserConnection userConnection)
			: base(userConnection) {
		}

		public DuplicatesHistory(Terrasoft.Configuration.DuplicatesHistory source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

