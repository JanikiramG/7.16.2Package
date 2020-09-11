namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: FileLead

	/// <exclude/>
	public class FileLead : Terrasoft.Configuration.FileLead
	{

		#region Constructors: Public

		public FileLead(UserConnection userConnection)
			: base(userConnection) {
		}

		public FileLead(Terrasoft.Configuration.FileLead source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

