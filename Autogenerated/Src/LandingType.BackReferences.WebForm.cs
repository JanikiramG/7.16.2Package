namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: LandingType

	/// <exclude/>
	public class LandingType : Terrasoft.Configuration.LandingType
	{

		#region Constructors: Public

		public LandingType(UserConnection userConnection)
			: base(userConnection) {
		}

		public LandingType(Terrasoft.Configuration.LandingType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<GeneratedWebForm> GeneratedWebFormCollectionByType {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

