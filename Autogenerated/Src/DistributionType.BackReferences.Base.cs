namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: DistributionType

	/// <exclude/>
	public class DistributionType : Terrasoft.Configuration.DistributionType
	{

		#region Constructors: Public

		public DistributionType(UserConnection userConnection)
			: base(userConnection) {
		}

		public DistributionType(Terrasoft.Configuration.DistributionType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

