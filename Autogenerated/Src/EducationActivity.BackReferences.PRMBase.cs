namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: EducationActivity

	/// <exclude/>
	public class EducationActivity : Terrasoft.Configuration.EducationActivity
	{

		#region Constructors: Public

		public EducationActivity(UserConnection userConnection)
			: base(userConnection) {
		}

		public EducationActivity(Terrasoft.Configuration.EducationActivity source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Certificate> CertificateCollectionByEducationActivity {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

