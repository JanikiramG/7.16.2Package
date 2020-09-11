namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: EduActivityType

	/// <exclude/>
	public class EduActivityType : Terrasoft.Configuration.EduActivityType
	{

		#region Constructors: Public

		public EduActivityType(UserConnection userConnection)
			: base(userConnection) {
		}

		public EduActivityType(Terrasoft.Configuration.EduActivityType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<EducationActivity> EducationActivityCollectionByEducationActivityType {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

