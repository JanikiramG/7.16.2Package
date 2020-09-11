namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: DomainInfo

	/// <exclude/>
	public class DomainInfo : Terrasoft.Configuration.DomainInfo
	{

		#region Constructors: Public

		public DomainInfo(UserConnection userConnection)
			: base(userConnection) {
		}

		public DomainInfo(Terrasoft.Configuration.DomainInfo source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

