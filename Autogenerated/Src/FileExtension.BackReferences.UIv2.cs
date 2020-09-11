namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: FileExtension

	/// <exclude/>
	public class FileExtension : Terrasoft.Configuration.FileExtension
	{

		#region Constructors: Public

		public FileExtension(UserConnection userConnection)
			: base(userConnection) {
		}

		public FileExtension(Terrasoft.Configuration.FileExtension source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

