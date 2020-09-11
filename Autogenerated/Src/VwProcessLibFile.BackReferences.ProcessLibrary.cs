namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwProcessLibFile

	/// <exclude/>
	public class VwProcessLibFile : Terrasoft.Configuration.VwProcessLibFile
	{

		#region Constructors: Public

		public VwProcessLibFile(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwProcessLibFile(Terrasoft.Configuration.VwProcessLibFile source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

