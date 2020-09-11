namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ExternalAccessFile

	/// <exclude/>
	public class ExternalAccessFile : Terrasoft.Configuration.ExternalAccessFile
	{

		#region Constructors: Public

		public ExternalAccessFile(UserConnection userConnection)
			: base(userConnection) {
		}

		public ExternalAccessFile(Terrasoft.Configuration.ExternalAccessFile source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

