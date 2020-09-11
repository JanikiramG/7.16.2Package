namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ChartProperty

	/// <exclude/>
	public class ChartProperty : Terrasoft.Configuration.ChartProperty
	{

		#region Constructors: Public

		public ChartProperty(UserConnection userConnection)
			: base(userConnection) {
		}

		public ChartProperty(Terrasoft.Configuration.ChartProperty source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

