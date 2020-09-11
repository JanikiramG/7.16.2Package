namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: QualifyStatus

	/// <exclude/>
	public class QualifyStatus : Terrasoft.Configuration.QualifyStatus
	{

		#region Constructors: Public

		public QualifyStatus(UserConnection userConnection)
			: base(userConnection) {
		}

		public QualifyStatus(Terrasoft.Configuration.QualifyStatus source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Lead> LeadCollectionByQualifyStatus {
			get;
			set;
		}

		public IEnumerable<LeadInQualifyStatus> LeadInQualifyStatusCollectionByQualifyStatus {
			get;
			set;
		}

		public IEnumerable<QualifyStatusDecoupling> QualifyStatusDecouplingCollectionByAvailableStatus {
			get;
			set;
		}

		public IEnumerable<QualifyStatusDecoupling> QualifyStatusDecouplingCollectionByCurrentStatus {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

