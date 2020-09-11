namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;

	#region Class: SysProcessElementDataOwner

	/// <summary>
	/// Manages owner of process element data.
	/// </summary>
	public class SysProcessElementDataOwner
	{

		#region Fields: Private

		private readonly UserConnection _userConnection;

		#endregion

		#region Constructors: Public

		/// <summary>
		/// Initializes new instance of <see cref="SysProcessElementDataOwner"/>
		/// </summary>
		/// <param name="userConnection">User connection.</param>
		public SysProcessElementDataOwner(UserConnection userConnection) {
			_userConnection = userConnection;
		}

		#endregion

		#region Methods: Private

		private Guid[] GetEntityProcesses(SysProcessElementDataOwnerInfo elementDataOwnerInfo) {
			var select = new Select(_userConnection)
				.Column("SysProcessId")
				.From("SysProcessEntity").WithHints(new NoLockHint())
				.Where("EntityId")
				.IsEqual(Column.Parameter(elementDataOwnerInfo.EntityId)) as Select;
			return select.ExecuteEnumerable(r => r.GetColumnValue<Guid>("SysProcessId")).ToArray();
		}

		private void UpdateSysProcessElementToDoOwner(IEnumerable<Guid> processesId, SysProcessElementDataOwnerInfo elementDataOwnerInfo) {
			new Update(_userConnection, "SysProcessElementToDo")
				.Set("ContactId", Column.Parameter(elementDataOwnerInfo.NewOwnerId))
				.Where("SysProcessDataId").In(Column.Parameters(processesId))
				.And("ContactId").IsEqual(Column.Parameter(elementDataOwnerInfo.OldOwnerId))
				.Execute();
		}

		private void UpdateSysProcessElementDataOwner(IEnumerable<Guid> processesId, SysProcessElementDataOwnerInfo elementDataOwnerInfo) {
			new Update(_userConnection, "SysProcessElementData")
				.Set("OwnerId", Column.Parameter(elementDataOwnerInfo.NewOwnerId))
				.Where("SysProcessId").In(Column.Parameters(processesId))
				.And("OwnerId").IsEqual(Column.Parameter(elementDataOwnerInfo.OldOwnerId))
				.Execute();
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Changes owner of process element data.
		/// <param name="elementDataOwnerInfo">Information about owner of process element data.</param>
		/// </summary>
		public void Change(SysProcessElementDataOwnerInfo elementDataOwnerInfo) {
			var ownerProcessesId = GetEntityProcesses(elementDataOwnerInfo);
			if (ownerProcessesId.Length > 0) {
				UpdateSysProcessElementDataOwner(ownerProcessesId, elementDataOwnerInfo);
				UpdateSysProcessElementToDoOwner(ownerProcessesId, elementDataOwnerInfo);
			}
		}

		#endregion
	}

	#endregion

}
