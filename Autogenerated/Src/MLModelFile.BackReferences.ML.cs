namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: MLModelFile

	/// <exclude/>
	public class MLModelFile : Terrasoft.Configuration.MLModelFile
	{

		#region Constructors: Public

		public MLModelFile(UserConnection userConnection)
			: base(userConnection) {
		}

		public MLModelFile(Terrasoft.Configuration.MLModelFile source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

