namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: BufferedImportEntity

	/// <exclude/>
	public class BufferedImportEntity : Terrasoft.Configuration.BufferedImportEntity
	{

		#region Constructors: Public

		public BufferedImportEntity(UserConnection userConnection)
			: base(userConnection) {
		}

		public BufferedImportEntity(Terrasoft.Configuration.BufferedImportEntity source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

