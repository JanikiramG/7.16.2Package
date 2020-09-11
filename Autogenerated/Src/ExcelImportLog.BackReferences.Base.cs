namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ExcelImportLog

	/// <exclude/>
	public class ExcelImportLog : Terrasoft.Configuration.ExcelImportLog
	{

		#region Constructors: Public

		public ExcelImportLog(UserConnection userConnection)
			: base(userConnection) {
		}

		public ExcelImportLog(Terrasoft.Configuration.ExcelImportLog source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

