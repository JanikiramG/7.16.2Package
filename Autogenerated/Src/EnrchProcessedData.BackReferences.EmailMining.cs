namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: EnrchProcessedData

	/// <exclude/>
	public class EnrchProcessedData : Terrasoft.Configuration.EnrchProcessedData
	{

		#region Constructors: Public

		public EnrchProcessedData(UserConnection userConnection)
			: base(userConnection) {
		}

		public EnrchProcessedData(Terrasoft.Configuration.EnrchProcessedData source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

