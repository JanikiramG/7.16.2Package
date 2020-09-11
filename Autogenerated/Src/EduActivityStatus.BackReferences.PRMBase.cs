namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: EduActivityStatus

	/// <exclude/>
	public class EduActivityStatus : Terrasoft.Configuration.EduActivityStatus
	{

		#region Constructors: Public

		public EduActivityStatus(UserConnection userConnection)
			: base(userConnection) {
		}

		public EduActivityStatus(Terrasoft.Configuration.EduActivityStatus source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<EducationActivity> EducationActivityCollectionByStatusOfActivity {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

