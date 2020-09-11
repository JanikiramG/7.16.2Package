namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: FileSecurityMode

	/// <exclude/>
	public class FileSecurityMode : Terrasoft.Configuration.FileSecurityMode
	{

		#region Constructors: Public

		public FileSecurityMode(UserConnection userConnection)
			: base(userConnection) {
		}

		public FileSecurityMode(Terrasoft.Configuration.FileSecurityMode source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

