namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysPrcHistoryLogBuffer

	/// <exclude/>
	public class SysPrcHistoryLogBuffer : Terrasoft.Configuration.SysPrcHistoryLogBuffer
	{

		#region Constructors: Public

		public SysPrcHistoryLogBuffer(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysPrcHistoryLogBuffer(Terrasoft.Configuration.SysPrcHistoryLogBuffer source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

