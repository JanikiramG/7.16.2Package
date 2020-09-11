namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: EmployeeFolder

	/// <exclude/>
	public class EmployeeFolder : Terrasoft.Configuration.EmployeeFolder
	{

		#region Constructors: Public

		public EmployeeFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public EmployeeFolder(Terrasoft.Configuration.EmployeeFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<EmployeeFolder> EmployeeFolderCollectionByParent {
			get;
			set;
		}

		public IEnumerable<EmployeeInFolder> EmployeeInFolderCollectionByFolder {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

