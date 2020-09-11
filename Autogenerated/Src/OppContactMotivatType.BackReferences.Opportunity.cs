namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: OppContactMotivatType

	/// <exclude/>
	public class OppContactMotivatType : Terrasoft.Configuration.OppContactMotivatType
	{

		#region Constructors: Public

		public OppContactMotivatType(UserConnection userConnection)
			: base(userConnection) {
		}

		public OppContactMotivatType(Terrasoft.Configuration.OppContactMotivatType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<OppContactMotivators> OppContactMotivatorsCollectionByType {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

