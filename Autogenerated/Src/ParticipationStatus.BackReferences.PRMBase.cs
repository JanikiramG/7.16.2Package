namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ParticipationStatus

	/// <exclude/>
	public class ParticipationStatus : Terrasoft.Configuration.ParticipationStatus
	{

		#region Constructors: Public

		public ParticipationStatus(UserConnection userConnection)
			: base(userConnection) {
		}

		public ParticipationStatus(Terrasoft.Configuration.ParticipationStatus source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

