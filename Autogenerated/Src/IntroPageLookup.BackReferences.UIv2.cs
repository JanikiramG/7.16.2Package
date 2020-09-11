namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: IntroPageLookup

	/// <exclude/>
	public class IntroPageLookup : Terrasoft.Configuration.IntroPageLookup
	{

		#region Constructors: Public

		public IntroPageLookup(UserConnection userConnection)
			: base(userConnection) {
		}

		public IntroPageLookup(Terrasoft.Configuration.IntroPageLookup source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

