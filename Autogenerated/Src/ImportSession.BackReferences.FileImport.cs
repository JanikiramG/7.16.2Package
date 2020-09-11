namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ImportSession

	/// <exclude/>
	public class ImportSession : Terrasoft.Configuration.ImportSession
	{

		#region Constructors: Public

		public ImportSession(UserConnection userConnection)
			: base(userConnection) {
		}

		public ImportSession(Terrasoft.Configuration.ImportSession source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

