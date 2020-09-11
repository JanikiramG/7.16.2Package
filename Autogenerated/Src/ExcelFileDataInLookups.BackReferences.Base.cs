namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ExcelFileDataInLookups

	/// <exclude/>
	public class ExcelFileDataInLookups : Terrasoft.Configuration.ExcelFileDataInLookups
	{

		#region Constructors: Public

		public ExcelFileDataInLookups(UserConnection userConnection)
			: base(userConnection) {
		}

		public ExcelFileDataInLookups(Terrasoft.Configuration.ExcelFileDataInLookups source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

