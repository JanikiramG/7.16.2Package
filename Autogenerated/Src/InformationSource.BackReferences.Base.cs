namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: InformationSource

	/// <exclude/>
	public class InformationSource : Terrasoft.Configuration.InformationSource
	{

		#region Constructors: Public

		public InformationSource(UserConnection userConnection)
			: base(userConnection) {
		}

		public InformationSource(Terrasoft.Configuration.InformationSource source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Lead> LeadCollectionByInformationSource {
			get;
			set;
		}

		public IEnumerable<LeadQualification> LeadQualificationCollectionByLeadSource {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

