namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: MLModelColumn

	/// <exclude/>
	public class MLModelColumn : Terrasoft.Configuration.MLModelColumn
	{

		#region Constructors: Public

		public MLModelColumn(UserConnection userConnection)
			: base(userConnection) {
		}

		public MLModelColumn(Terrasoft.Configuration.MLModelColumn source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

