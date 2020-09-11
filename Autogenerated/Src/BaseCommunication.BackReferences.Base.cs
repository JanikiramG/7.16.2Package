namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: BaseCommunication

	/// <exclude/>
	public class BaseCommunication : Terrasoft.Configuration.BaseCommunication
	{

		#region Constructors: Public

		public BaseCommunication(UserConnection userConnection)
			: base(userConnection) {
		}

		public BaseCommunication(Terrasoft.Configuration.BaseCommunication source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

