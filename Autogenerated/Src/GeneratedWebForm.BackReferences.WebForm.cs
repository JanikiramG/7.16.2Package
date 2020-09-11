namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: GeneratedWebForm

	/// <exclude/>
	public class GeneratedWebForm : Terrasoft.Configuration.GeneratedWebForm
	{

		#region Constructors: Public

		public GeneratedWebForm(UserConnection userConnection)
			: base(userConnection) {
		}

		public GeneratedWebForm(Terrasoft.Configuration.GeneratedWebForm source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<GeneratedWebFormFile> GeneratedWebFormFileCollectionByGeneratedWebForm {
			get;
			set;
		}

		public IEnumerable<GeneratedWebFormInFolder> GeneratedWebFormInFolderCollectionByGeneratedWebForm {
			get;
			set;
		}

		public IEnumerable<GeneratedWebFormInTag> GeneratedWebFormInTagCollectionByEntity {
			get;
			set;
		}

		public IEnumerable<LandingLeadDefaults> LandingLeadDefaultsCollectionByLanding {
			get;
			set;
		}

		public IEnumerable<LandingObjectDefaults> LandingObjectDefaultsCollectionByLanding {
			get;
			set;
		}

		public IEnumerable<Lead> LeadCollectionByWebForm {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

