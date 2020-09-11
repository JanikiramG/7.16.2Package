namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: GroupByTypeDateTime

	/// <exclude/>
	public class GroupByTypeDateTime : Terrasoft.Configuration.GroupByTypeDateTime
	{

		#region Constructors: Public

		public GroupByTypeDateTime(UserConnection userConnection)
			: base(userConnection) {
		}

		public GroupByTypeDateTime(Terrasoft.Configuration.GroupByTypeDateTime source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<ChartProperty> ChartPropertyCollectionByGroupByTypeDateTime {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

