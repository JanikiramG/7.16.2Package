namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: Certificate

	/// <exclude/>
	public class Certificate : Terrasoft.Configuration.Certificate
	{

		#region Constructors: Public

		public Certificate(UserConnection userConnection)
			: base(userConnection) {
		}

		public Certificate(Terrasoft.Configuration.Certificate source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

