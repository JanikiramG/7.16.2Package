namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: Command

	/// <exclude/>
	public class Command : Terrasoft.Configuration.Command
	{

		#region Constructors: Public

		public Command(UserConnection userConnection)
			: base(userConnection) {
		}

		public Command(Terrasoft.Configuration.Command source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<CommandParams> CommandParamsCollectionByCommand {
			get;
			set;
		}

		public IEnumerable<Macros> MacrosCollectionByCommand {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

