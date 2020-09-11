namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: OppStageDecoupling

	/// <exclude/>
	public class OppStageDecoupling : Terrasoft.Configuration.OppStageDecoupling
	{

		#region Constructors: Public

		public OppStageDecoupling(UserConnection userConnection)
			: base(userConnection) {
		}

		public OppStageDecoupling(Terrasoft.Configuration.OppStageDecoupling source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

