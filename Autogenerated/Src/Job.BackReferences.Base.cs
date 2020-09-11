namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: Job

	/// <exclude/>
	public class Job : Terrasoft.Configuration.Job
	{

		#region Constructors: Public

		public Job(UserConnection userConnection)
			: base(userConnection) {
		}

		public Job(Terrasoft.Configuration.Job source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Contact> ContactCollectionByJob {
			get;
			set;
		}

		public IEnumerable<ContactCareer> ContactCareerCollectionByJob {
			get;
			set;
		}

		public IEnumerable<Lead> LeadCollectionByJob {
			get;
			set;
		}

		public IEnumerable<LeadQualification> LeadQualificationCollectionByJob {
			get;
			set;
		}

		public IEnumerable<ProjectRole> ProjectRoleCollectionByJobTitle {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

