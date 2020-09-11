namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: JobChangeReason

	/// <exclude/>
	public class JobChangeReason : Terrasoft.Configuration.JobChangeReason
	{

		#region Constructors: Public

		public JobChangeReason(UserConnection userConnection)
			: base(userConnection) {
		}

		public JobChangeReason(Terrasoft.Configuration.JobChangeReason source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<ContactCareer> ContactCareerCollectionByJobChangeReason {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

