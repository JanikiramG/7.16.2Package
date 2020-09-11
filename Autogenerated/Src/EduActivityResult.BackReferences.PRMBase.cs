namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: EduActivityResult

	/// <exclude/>
	public class EduActivityResult : Terrasoft.Configuration.EduActivityResult
	{

		#region Constructors: Public

		public EduActivityResult(UserConnection userConnection)
			: base(userConnection) {
		}

		public EduActivityResult(Terrasoft.Configuration.EduActivityResult source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<EducationActivity> EducationActivityCollectionByEducationActivityResult {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

