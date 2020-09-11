namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: DuplicatesSearchParameter

	/// <exclude/>
	public class DuplicatesSearchParameter : Terrasoft.Configuration.DuplicatesSearchParameter
	{

		#region Constructors: Public

		public DuplicatesSearchParameter(UserConnection userConnection)
			: base(userConnection) {
		}

		public DuplicatesSearchParameter(Terrasoft.Configuration.DuplicatesSearchParameter source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

