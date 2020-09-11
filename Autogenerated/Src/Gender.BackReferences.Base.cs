namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: Gender

	/// <exclude/>
	public class Gender : Terrasoft.Configuration.Gender
	{

		#region Constructors: Public

		public Gender(UserConnection userConnection)
			: base(userConnection) {
		}

		public Gender(Terrasoft.Configuration.Gender source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Contact> ContactCollectionByGender {
			get;
			set;
		}

		public IEnumerable<Lead> LeadCollectionByGender {
			get;
			set;
		}

		public IEnumerable<LeadQualification> LeadQualificationCollectionByGender {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

