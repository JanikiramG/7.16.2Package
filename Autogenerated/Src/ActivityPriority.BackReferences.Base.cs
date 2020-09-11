namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ActivityPriority

	/// <exclude/>
	public class ActivityPriority : Terrasoft.Configuration.ActivityPriority
	{

		#region Constructors: Public

		public ActivityPriority(UserConnection userConnection)
			: base(userConnection) {
		}

		public ActivityPriority(Terrasoft.Configuration.ActivityPriority source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Activity> ActivityCollectionByPriority {
			get;
			set;
		}

		public IEnumerable<EmailTemplate> EmailTemplateCollectionByPriority {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

