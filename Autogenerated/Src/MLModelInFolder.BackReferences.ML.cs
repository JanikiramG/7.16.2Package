namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: MLModelInFolder

	/// <exclude/>
	public class MLModelInFolder : Terrasoft.Configuration.MLModelInFolder
	{

		#region Constructors: Public

		public MLModelInFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public MLModelInFolder(Terrasoft.Configuration.MLModelInFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

