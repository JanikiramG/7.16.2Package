namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: DialingCode

	/// <exclude/>
	public class DialingCode : Terrasoft.Configuration.DialingCode
	{

		#region Constructors: Public

		public DialingCode(UserConnection userConnection)
			: base(userConnection) {
		}

		public DialingCode(Terrasoft.Configuration.DialingCode source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

