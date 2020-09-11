namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ExternalAccessInFolder

	/// <exclude/>
	public class ExternalAccessInFolder : Terrasoft.Configuration.ExternalAccessInFolder
	{

		#region Constructors: Public

		public ExternalAccessInFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public ExternalAccessInFolder(Terrasoft.Configuration.ExternalAccessInFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

