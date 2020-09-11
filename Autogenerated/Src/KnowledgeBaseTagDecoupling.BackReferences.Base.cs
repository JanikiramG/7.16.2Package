namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: KnowledgeBaseTagDecoupling

	/// <exclude/>
	public class KnowledgeBaseTagDecoupling : Terrasoft.Configuration.KnowledgeBaseTagDecoupling
	{

		#region Constructors: Public

		public KnowledgeBaseTagDecoupling(UserConnection userConnection)
			: base(userConnection) {
		}

		public KnowledgeBaseTagDecoupling(Terrasoft.Configuration.KnowledgeBaseTagDecoupling source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

