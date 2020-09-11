namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: EnrchEmailData

	/// <exclude/>
	public class EnrchEmailData : Terrasoft.Configuration.EnrchEmailData
	{

		#region Constructors: Public

		public EnrchEmailData(UserConnection userConnection)
			: base(userConnection) {
		}

		public EnrchEmailData(Terrasoft.Configuration.EnrchEmailData source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Activity> ActivityCollectionByEnrchEmailData {
			get;
			set;
		}

		public IEnumerable<EnrchTextEntity> EnrchTextEntityCollectionByEnrchEmailData {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

