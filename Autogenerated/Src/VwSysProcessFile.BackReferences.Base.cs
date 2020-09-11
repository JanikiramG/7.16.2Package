namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwSysProcessFile

	/// <exclude/>
	public class VwSysProcessFile : Terrasoft.Configuration.VwSysProcessFile
	{

		#region Constructors: Public

		public VwSysProcessFile(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwSysProcessFile(Terrasoft.Configuration.VwSysProcessFile source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

