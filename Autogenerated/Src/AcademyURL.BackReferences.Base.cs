namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: AcademyURL

	/// <exclude/>
	public class AcademyURL : Terrasoft.Configuration.AcademyURL
	{

		#region Constructors: Public
		//test1
		public AcademyURL(UserConnection userConnection)
			: base(userConnection) {
		}

		public AcademyURL(Terrasoft.Configuration.AcademyURL source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

