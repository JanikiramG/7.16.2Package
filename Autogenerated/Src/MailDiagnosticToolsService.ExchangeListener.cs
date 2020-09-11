namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Net;
	using System.Runtime.Serialization;
	using System.ServiceModel;
	using System.ServiceModel.Activation;
	using System.ServiceModel.Web;
	using Terrasoft.Core.Factories;
	using Terrasoft.Web.Common;
	using IntegrationApi.Interfaces;
	using IntegrationApi.MailboxDomain.Interfaces;
	using BaseResponse = Core.ServiceModelContract.BaseResponse;
	using ErrorInfo = Core.ServiceModelContract.ErrorInfo;

	#region Class: MailDiagnosticToolsService

	[ServiceContract]
	[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
	public class MailDiagnosticToolsService : BaseService
	{

		#region Fields: Private

		/// <summary>
		/// <see cref="IMailboxService"/> implementation instance.
		/// </summary>
		private readonly IMailboxService _mailboxService;

		/// <summary>
		/// <see cref="IExchangeListenerManager"/> implementation instance.
		/// </summary>
		private readonly IExchangeListenerManager _exchangeListenerManager;

		#endregion

		#region Constructors: Public

		/// <summary>
		/// ctor.
		/// </summary>
		public MailDiagnosticToolsService() : base() {
			_mailboxService =
				ClassFactory.Get<IMailboxService>(new ConstructorArgument("uc", UserConnection));
			_exchangeListenerManager = GetExchangeListenerManager();
		}

		#endregion

		#region Methods: Private

		/// <summary>
		/// Creates <see cref="ExchangeListenerManager"/> instance.
		/// </summary>
		private IExchangeListenerManager GetExchangeListenerManager() {
			var managerFactory = ClassFactory.Get<IListenerManagerFactory>();
			return managerFactory.GetExchangeListenerManager(UserConnection);
		}

		/// <summary>
		/// Get all mailboxes Ids.
		/// </summary>
		/// <returns></returns>
		private Guid[] GetAllMailboxIds() {
			var mailboxes = _mailboxService.GetAllSynchronizableMailboxes();
			return mailboxes.Select(x => x.Id).ToArray<Guid>();
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Checks that ExchangeListener service avaliable.
		/// </summary>
		/// <returns><c>True</c> if exchange listeners service avaliable. Otherwise returns <c>false</c>.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json)]
		public bool GetIsExchangeListenerAvaliable() {
			return _exchangeListenerManager.GetIsServiceAvaliable();
		}

		/// <summary>
		/// Get ExchangeListener subscribers info.
		/// </summary>
		/// <returns><see cref="DiagnosticResponse"/> instance.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json)]
		public DiagnosticResponse GetSubscriberInfo() {
			try {
				var mailboxesIds = GetAllMailboxIds();
				var subscribersInfo = _exchangeListenerManager.GetSubscriptionsStatuses(mailboxesIds);
				return new DiagnosticResponse {
					Success = true,
					Subscribers = subscribersInfo
				};
			} catch (Exception e) {
				throw new WebFaultException<DiagnosticResponse>(
					new DiagnosticResponse {
						Success = false,
						ErrorInfo = new ErrorInfo {
							Message = e.Message,
							StackTrace = e.StackTrace
						}
					},
					HttpStatusCode.InternalServerError);
			}
		}

		#endregion

		#region Class: DiagnosticResponse

		/// <summary>
		/// Response to creatio.
		/// </summary>
		[DataContract]
		public class DiagnosticResponse : BaseResponse
		{
			/// <summary>
			/// Subscribers result.
			/// </summary>
			[DataMember(Name = "result")]
			public Dictionary<Guid, string> Subscribers {
				get;
				set;
			}
		}

		#endregion

	}

	#endregion
}
