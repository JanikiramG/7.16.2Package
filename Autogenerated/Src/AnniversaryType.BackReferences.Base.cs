namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: AnniversaryType

	/// <exclude/>
	public class AnniversaryType : Terrasoft.Configuration.AnniversaryType
	{

		#region Constructors: Public

		public AnniversaryType(UserConnection userConnection)
			: base(userConnection) {
		}

		public AnniversaryType(Terrasoft.Configuration.AnniversaryType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<AccountAnniversary> AccountAnniversaryCollectionByAnniversaryType {
			get;
			set;
		}

		public IEnumerable<ContactAnniversary> ContactAnniversaryCollectionByAnniversaryType {
			get;
			set;
		}

		public IEnumerable<VwAnniversary> VwAnniversaryCollectionByAnniversaryType {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

