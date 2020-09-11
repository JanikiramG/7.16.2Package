namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: BuildTypeEntity

	/// <exclude/>
	public class BuildTypeEntity : Terrasoft.Configuration.BuildTypeEntity
	{

		#region Constructors: Public

		public BuildTypeEntity(UserConnection userConnection)
			: base(userConnection) {
		}

		public BuildTypeEntity(Terrasoft.Configuration.BuildTypeEntity source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

