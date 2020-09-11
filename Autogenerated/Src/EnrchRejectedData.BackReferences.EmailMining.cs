namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: EnrchRejectedData

	/// <exclude/>
	public class EnrchRejectedData : Terrasoft.Configuration.EnrchRejectedData
	{

		#region Constructors: Public

		public EnrchRejectedData(UserConnection userConnection)
			: base(userConnection) {
		}

		public EnrchRejectedData(Terrasoft.Configuration.EnrchRejectedData source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

