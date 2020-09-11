namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: EnrchTextEntity

	/// <exclude/>
	public class EnrchTextEntity : Terrasoft.Configuration.EnrchTextEntity
	{

		#region Constructors: Public

		public EnrchTextEntity(UserConnection userConnection)
			: base(userConnection) {
		}

		public EnrchTextEntity(Terrasoft.Configuration.EnrchTextEntity source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<EnrchFoundAccount> EnrchFoundAccountCollectionByEnrchTextEntity {
			get;
			set;
		}

		public IEnumerable<EnrchFoundContact> EnrchFoundContactCollectionByEnrchTextEntity {
			get;
			set;
		}

		public IEnumerable<EnrchTextEntity> EnrchTextEntityCollectionByParent {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

