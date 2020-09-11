namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ActivityParticipant

	/// <exclude/>
	public class ActivityParticipant : Terrasoft.Configuration.ActivityParticipant
	{

		#region Constructors: Public

		public ActivityParticipant(UserConnection userConnection)
			: base(userConnection) {
		}

		public ActivityParticipant(Terrasoft.Configuration.ActivityParticipant source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

