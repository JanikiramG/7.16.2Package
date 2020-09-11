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

	#region Class : CertificatesActualizationJob

	/// <summary>
	/// A class that represents certificates actualization job.
	/// </summary>
	public class CertificatesActualizationJob : IJobExecutor
	{

		#region Methods : Public

		/// <summary>
		/// Runs actualization for all certificates in active partnerships.
		/// </summary>
		/// <param name="userConnection">User connection.</param>
		/// <param name="parameters">Parameters.</param>
		public virtual void Execute(UserConnection userConnection, IDictionary<string, object> parameters) {
			CertificateUtils.ActualizeAll(userConnection);
		}

		#endregion

	}

	#endregion

}
