namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: EmailType

	/// <exclude/>
	public class EmailType : Terrasoft.Configuration.EmailType
	{

		#region Constructors: Public

		public EmailType(UserConnection userConnection)
			: base(userConnection) {
		}

		public EmailType(Terrasoft.Configuration.EmailType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Activity> ActivityCollectionByMessageType {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

