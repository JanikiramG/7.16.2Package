namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: EmailSynchronizedKey

	/// <exclude/>
	public class EmailSynchronizedKey : Terrasoft.Configuration.EmailSynchronizedKey
	{

		#region Constructors: Public

		public EmailSynchronizedKey(UserConnection userConnection)
			: base(userConnection) {
		}

		public EmailSynchronizedKey(Terrasoft.Configuration.EmailSynchronizedKey source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

