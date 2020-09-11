namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: CompetenceLevel

	/// <exclude/>
	public class CompetenceLevel : Terrasoft.Configuration.CompetenceLevel
	{

		#region Constructors: Public

		public CompetenceLevel(UserConnection userConnection)
			: base(userConnection) {
		}

		public CompetenceLevel(Terrasoft.Configuration.CompetenceLevel source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Certificate> CertificateCollectionByCompetenceLevel {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

