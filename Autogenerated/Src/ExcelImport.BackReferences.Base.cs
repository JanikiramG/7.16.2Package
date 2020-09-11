namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ExcelImport

	/// <exclude/>
	public class ExcelImport : Terrasoft.Configuration.ExcelImport
	{

		#region Constructors: Public

		public ExcelImport(UserConnection userConnection)
			: base(userConnection) {
		}

		public ExcelImport(Terrasoft.Configuration.ExcelImport source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<ExcelImportLog> ExcelImportLogCollectionByExcelImport {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

