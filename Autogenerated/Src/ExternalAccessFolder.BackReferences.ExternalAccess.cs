namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ExternalAccessFolder

	/// <exclude/>
	public class ExternalAccessFolder : Terrasoft.Configuration.ExternalAccessFolder
	{

		#region Constructors: Public

		public ExternalAccessFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public ExternalAccessFolder(Terrasoft.Configuration.ExternalAccessFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<ExternalAccessFolder> ExternalAccessFolderCollectionByParent {
			get;
			set;
		}

		public IEnumerable<ExternalAccessInFolder> ExternalAccessInFolderCollectionByFolder {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

