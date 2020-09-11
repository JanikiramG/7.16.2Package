namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: AdditionalParam

	/// <exclude/>
	public class AdditionalParam : Terrasoft.Configuration.AdditionalParam
	{

		#region Constructors: Public

		public AdditionalParam(UserConnection userConnection)
			: base(userConnection) {
		}

		public AdditionalParam(Terrasoft.Configuration.AdditionalParam source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<CommandParams> CommandParamsCollectionByAdditionalParam {
			get;
			set;
		}

		public IEnumerable<Macros> MacrosCollectionByAdditionalParam {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

