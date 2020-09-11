namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: EmailTemplateMacros

	/// <exclude/>
	public class EmailTemplateMacros : Terrasoft.Configuration.EmailTemplateMacros
	{

		#region Constructors: Public

		public EmailTemplateMacros(UserConnection userConnection)
			: base(userConnection) {
		}

		public EmailTemplateMacros(Terrasoft.Configuration.EmailTemplateMacros source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<EmailTemplateMacros> EmailTemplateMacrosCollectionByParent {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

