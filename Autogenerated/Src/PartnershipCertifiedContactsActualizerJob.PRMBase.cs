namespace Terrasoft.Configuration 
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Linq;
	using global::Common.Logging;
	using Newtonsoft.Json;
	using Quartz;
	using Quartz.Impl.Matchers;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Scheduler;
	using Terrasoft.Messaging.Common;

	#region Class: PartnershipCertifiedContactsActualizerJob

	/// <summary>
	/// Represents periodical task for partnership certified contacts actualization.
	/// </summary>
	public class PartnershipCertifiedContactsActualizerJob : IJobExecutor 
	{

		#region Fields: Private

		/// <summary>
		/// Logger instance.
		/// </summary>
		private static readonly ILog _log = LogManager.GetLogger("Terrasoft");
		
		/// <summary>
		/// Instance of the <see cref="EntityDataActualizer"/> class for actualization.
		/// </summary>
		private EntityDataActualizer _entityDataActualizer;

		#endregion

		#region Constructors: Public

		/// <summary>
		/// Initializes a new instance of the <see cref="PartnershipCertifiedContactsActualizerJob"/> class.
		/// </summary>
		public PartnershipCertifiedContactsActualizerJob() {
		}

		#endregion

		#region Methods: Private

		/// <summary>
		/// Log error from job.
		/// </summary>
		/// <param name="exception">Exception instance for logging.</param>
		private void LogError(Exception exception) {
			_log.ErrorFormat("Exception where thrown during partnership certified contacts actualizer job.", exception);
		}

		/// <summary>
		/// Configure EntityDataActualizer before execution.
		/// </summary>
		/// <param name="userConnection">instance. </param>
		private void ConfigureEntityDataActualizer(UserConnection userConnection) {		
			var entityDataContext = new EntityActualizatorDataContext(userConnection);
			var dataExtractor = new PartnershipCertifiedContactsDataExtractor(userConnection);
			_entityDataActualizer = new EntityDataActualizer(userConnection, dataExtractor, entityDataContext);
		}

		/// <summary>
		/// Return mapping for entity columns.
		/// </summary>
		/// <returns>Dictionary with mapping for entity columns.</returns>
		private Dictionary<string, string>  GetColumnsMapping() {
			var columnsMapping = new Dictionary<string, string>() {
				{ "Id", "Id" },
				{ "Count", "IntValue" }
			};
			return columnsMapping;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Runs EntityDataActualizer for PartnershipCertificatedContacts.
		/// </summary>
		/// <param name="userConnection">User connection.</param>
		/// <param name="parameters">Job parameters.</param>
		public void Execute(UserConnection userConnection, IDictionary<string, object> parameters) {
			try {
				ConfigureEntityDataActualizer(userConnection);
				_entityDataActualizer.Actualize("Id", "PartnershipParameter", GetColumnsMapping());
			}
			catch (Exception ex) {
				LogError(ex);
				throw;
			}
		}

		#endregion

	}

	#endregion

}
