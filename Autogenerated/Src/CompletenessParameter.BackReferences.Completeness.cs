namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: CompletenessParameter

	/// <exclude/>
	public class CompletenessParameter : Terrasoft.Configuration.CompletenessParameter
	{

		#region Constructors: Public

		public CompletenessParameter(UserConnection userConnection)
			: base(userConnection) {
		}

		public CompletenessParameter(Terrasoft.Configuration.CompletenessParameter source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

