namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: LookupInFolder

	/// <exclude/>
	public class LookupInFolder : Terrasoft.Configuration.LookupInFolder
	{

		#region Constructors: Public

		public LookupInFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public LookupInFolder(Terrasoft.Configuration.LookupInFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

