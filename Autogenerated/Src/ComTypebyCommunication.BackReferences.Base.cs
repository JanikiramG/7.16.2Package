namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ComTypebyCommunication

	/// <exclude/>
	public class ComTypebyCommunication : Terrasoft.Configuration.ComTypebyCommunication
	{

		#region Constructors: Public

		public ComTypebyCommunication(UserConnection userConnection)
			: base(userConnection) {
		}

		public ComTypebyCommunication(Terrasoft.Configuration.ComTypebyCommunication source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

