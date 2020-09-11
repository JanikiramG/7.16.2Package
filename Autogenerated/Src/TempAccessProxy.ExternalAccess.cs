namespace Terrasoft.Configuration.ExternalAccessPackage
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Net;
	using System.Net.Http;
	using System.Net.Sockets;
	using System.Threading.Tasks;
	using RestSharp;
	using Terrasoft.Common;
	using Terrasoft.Core.Factories;
	using Terrasoft.Services;

	#region Interface: ITempAccessProxy

	/// <summary>
	/// Proxy for TempAccess service Api.
	/// </summary>
	public interface ITempAccessProxy
	{

		#region Methods: Public

		/// <summary>
		/// Grants the access.
		/// </summary>
		/// <param name="resourceName">Name of the resource.</param>
		/// <param name="reason">The reason.</param>
		/// <param name="expirationDate">The expiration date.</param>
		/// <param name="grantorSysAdminUnitId">The grantor system admin unit id.</param>
		/// <param name="granteeClientIds">The grantee client ids.</param>
		void GrantAccess(string resourceName, string reason, DateTime expirationDate, Guid grantorSysAdminUnitId,
			string[] granteeClientIds);

		/// <summary>
		/// Enumerate granted access list.
		/// </summary>
		/// <param name="customerIds">The customer ids (Access grantors).</param>
		/// <param name="clientId">Access grantor's client id. If set, accesses of the given client will be added to
		/// the result set.</param>
		List<(string AccessId, string Url, string Description, DateTime ExpirationDate, string CustomerId)>
			GetAccessList(string[] customerIds, string clientId = null);

		/// <summary>
		/// Request access token.
		/// </summary>
		/// <param name="accessId">Access id.</param>
		string GetAccessToken(string accessId);

		#endregion

	}

	#endregion

	#region Interface: ITempAccessDeactivator

	/// <summary>
	/// Proxy for TempAccess deactivation Api.
	/// </summary>
	public interface ITempAccessDeactivator
	{

		#region Methods: Public

		/// <summary>Deactivates the specified access ids.</summary>
		/// <param name="accessIds">The access ids.</param>
		/// <returns>Affected access count.</returns>
		int Deactivate(string[] accessIds);

		#endregion

	}

	#endregion

	#region Interface: IIdentityServiceClientFinder

	/// <summary>
	/// Proxy for Identity service client finder Api.
	/// </summary>
	public interface IIdentityServiceClientFinder
	{

		#region Methods: Public

		/// <summary>Searches clients by customer ids or client id.</summary>
		/// <param name="clientsFilter">Filter info (customerIds, clientId, etc.) to search clients.</param>
		IList<ShortIdentityClientInfo> Search(FindIdentityClientsFilter clientsFilter);

		#endregion

	}

	#endregion

	#region Class: TempAccessProxy

	/// <summary>
	/// Default proxy for TempAccess service Api.
	/// </summary>
	/// <seealso cref="Terrasoft.Configuration.ExternalAccessPackage.ITempAccessProxy" />
	[DefaultBinding(typeof(ITempAccessProxy))]
	[DefaultBinding(typeof(ITempAccessDeactivator))]
	[DefaultBinding(typeof(IIdentityServiceClientFinder))]
	public class TempAccessProxy : ITempAccessProxy, ITempAccessDeactivator, IIdentityServiceClientFinder
	{

		#region Constants: Public

		public const string RegisterAccessScopes = "register_own_resource IdentityServerApi";
		public const string ListAccessScopes = "get_resource_list IdentityServerApi";
		public const string ClientInfoScopes = "get_client_info IdentityServerApi";
		public const string FindClientsScopes = "find_clients IdentityServerApi";
		public const int RegistrationTimeoutMs = 20000;
		public const string RegisterAccessMethod = "OwnedResources/register";
		public const string ListAccessMethod = "OwnedResources/list";
		public const string RemoveAccessesMethod = "OwnedResources/delete";
		public const string FindClientsMethod = "Clients/find";

		#endregion

		#region Fields: Private

		private readonly string _serverUrl;
		private readonly string _clientId;
		private readonly string _clientSecret;

		#endregion

		#region Constructors: Public

		/// <summary>
		/// Initializes a new instance of the <see cref="TempAccessProxy"/> class.
		/// </summary>
		/// <param name="serverUrl">The identity server URL.</param>
		/// <param name="clientId">The application client id.</param>
		/// <param name="clientSecret">The client secret.</param>
		public TempAccessProxy(string serverUrl, string clientId, string clientSecret) {
			serverUrl.CheckArgumentNullOrWhiteSpace(nameof(serverUrl));
			clientId.CheckArgumentNullOrWhiteSpace(nameof(clientId));
			_serverUrl = serverUrl;
			_clientId = clientId;
			_clientSecret = clientSecret;
		}

		#endregion

		#region Properties: Public

		private IRestClient _restClient;

		/// <summary>
		/// Gets or sets the rest client for Api calls.
		/// </summary>
		/// <value>
		/// The rest client.
		/// </value>
		public IRestClient RestClient {
			get {
				if (_restClient == null) {
					_restClient = new RestClient {
#if NETFRAMEWORK
						BaseUrl = _serverUrl
#else
						BaseUrl = new Uri(_serverUrl)
#endif
					};
					_restClient.AddDefaultHeader("Content-Type", "application/json");
				}
				return _restClient;
			}
			set {
				_restClient = value;
			}
		}

		#endregion

		#region Methods: Private

		private static void HandleRestClientError(IRestResponse response) {
			if (response.ErrorException != null) {
				throw response.ErrorException;
			}
			if (response.ResponseStatus != ResponseStatus.Completed && response.ErrorMessage.IsNotNullOrEmpty()) {
				var message = $"[{response.ResponseStatus}]: {response.ErrorMessage}";
				throw new ApiServerConnectivityException(message);
			}
			bool isErrorStatusCode = (int)response.StatusCode >= 300;
			if (isErrorStatusCode) {
				throw new ApiServerException($"{response.StatusCode} {response.Content}");
			}
		}

		private string RequestAccessToken(string scopes) {
			var serverAddress = new ConstructorArgument("serverAddress", _serverUrl);
			var identityClient = ClassFactory.Get<IIdentityClient>(serverAddress);
			Task<string> resultTask;
			string token;
			try {
				resultTask =
					identityClient.RequestClientCredentialsTokenAsync(_clientId, _clientSecret, scopes);
				resultTask.ConfigureAwait(false);
				resultTask.Wait(RegistrationTimeoutMs);
			} catch (AggregateException ex) when (ex.InnerException?.InnerException is HttpRequestException) {
				throw new ApiServerException(
					$"IdentityServer auth failed with {ex.InnerException.InnerException.Message}",
					ex.InnerException.InnerException);
			} catch (AggregateException ex) when (ex.InnerException is InvalidOperationException) {
				throw new ApiServerConnectivityException(ex.InnerException.Message, ex.InnerException);
			} catch (Exception ex) when (ex.InnerException?.InnerException is SocketException) {
				throw new ApiServerConnectivityException(ex.InnerException.InnerException.Message,
					ex.InnerException.InnerException);
			} catch (AggregateException ex) when (ex.InnerException?.InnerException is WebException) {
				throw new ApiServerConnectivityException(ex.InnerException.InnerException.Message,
					ex.InnerException.InnerException);
			} catch (Exception ex) {
				throw new ApiServerException($"Unknown error while requesting access token: {ex.ToString()}", ex);
			}
			if (!resultTask.IsCompleted) {
				throw new ApiServerConnectivityException("IdentityServer busy or unaccessable.");
			}
			token = resultTask.Result;
			return token;
		}

		private IRestRequest PrepareJsonPostRequest(object data, string apiMethod, string securityToken) {
			var request = new RestRequest {
				Method = Method.POST,
				RequestFormat = DataFormat.Json
			};
#if NETFRAMEWORK
			request.AddBody(data);
#else
			request.AddJsonBody(data);
#endif
			request.Resource = apiMethod;
			request.AddHeader("Authorization", $"Bearer {securityToken}");
			return request;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Grants the access.
		/// </summary>
		/// <param name="resourceName">Name of the resource.</param>
		/// <param name="reason">The reason.</param>
		/// <param name="expirationDate">The expiration date.</param>
		/// <param name="grantorSysAdminUnitId">The grantor system admin unit id.</param>
		/// <param name="granteeClientIds">The grantee client ids.</param>
		public void GrantAccess(string resourceName, string reason, DateTime expirationDate, Guid grantorSysAdminUnitId,
				string[] granteeClientIds) {
			resourceName.CheckArgumentNullOrWhiteSpace(nameof(resourceName));
			string token = RequestAccessToken(RegisterAccessScopes);
			var apiResource = new {
				Name = resourceName,
				DisplayName = reason,
				Properties = new {
					ExpirationDate = expirationDate.ToUniversalTime().ToString("o"),
					SysAdminUnitId = grantorSysAdminUnitId.ToString(),
					Type = "TempAccess"
				}
			};
			var data = new {
				ResourceInfo = apiResource,
				granteeClientIds
			};
			IRestRequest request = PrepareJsonPostRequest(data, RegisterAccessMethod, token);
			IRestResponse response = RestClient.Post(request);
			HandleRestClientError(response);
		}

		/// <summary>
		/// Enumerate granted access list.
		/// </summary>
		/// <param name="customerIds">The customer ids (Access grantors).</param>
		/// <param name="clientId">Access grantor's client id. If set, accesses of the given client will be added to
		/// the result set.</param>
		public List<(string AccessId, string Url, string Description, DateTime ExpirationDate, string CustomerId)>
				GetAccessList(string[] customerIds, string clientId = null) {
			if (customerIds.IsNullOrEmpty() && clientId.IsNullOrEmpty()) {
				throw new ArgumentNullOrEmptyException($"{nameof(customerIds)} or {nameof(clientId)}");
			}
			string token = RequestAccessToken(ListAccessScopes);
			var data = new {
				Type = "TempAccess",
				CustomerIds = customerIds,
				ClientId = clientId
			};
			IRestRequest request = PrepareJsonPostRequest(data, ListAccessMethod, token);
			IRestResponse<List<ClientResources>> response = RestClient.Post<List<ClientResources>>(request);
			HandleRestClientError(response);
			List<ClientResources> resources = response.Data;
			var result = resources.SelectMany(clientInfo => clientInfo.Resources.Select(item => (
				AccessId: item.Name,
				Url: clientInfo.ClientUri,
				Description: item.DisplayName,
				item.ExpirationDate,
				clientInfo.CustomerId
			))).ToList();
			return result;
		}

		/// <summary>
		/// Request access token.
		/// </summary>
		/// <param name="accessId">The access id.</param>
		/// <returns></returns>
		public string GetAccessToken(string accessId) {
			return RequestAccessToken(accessId);
		}

		/// <summary>Deactivates the specified access list.</summary>
		/// <param name="accessIds">The access ids.</param>
		/// <returns>Affected access count.</returns>
		public int Deactivate(string[] accessIds) {
			string token = RequestAccessToken(RegisterAccessScopes);
			var data = new {
				Resources = accessIds
			};
			IRestRequest request = PrepareJsonPostRequest(data, RemoveAccessesMethod, token);
			IRestResponse response = RestClient.Post(request);
			HandleRestClientError(response);
			var parsedResponse = Newtonsoft.Json.Linq.JObject.Parse(response.Content);
			int affectedRecords = parsedResponse.Value<int>("affectedResourceCount");
			return affectedRecords;
		}

		/// <summary>Searches clients by customer ids or client id.</summary>
		/// <param name="clientsFilter">Filter info (customerIds, clientId, etc.) to search clients.</param>
		public IList<ShortIdentityClientInfo> Search(FindIdentityClientsFilter clientsFilter) {
			if (clientsFilter.CustomerIds.IsNullOrEmpty() && clientsFilter.ClientId.IsNullOrEmpty()) {
				throw new ArgumentNullOrEmptyException($"{nameof(clientsFilter.CustomerIds)} or " +
					$"{nameof(clientsFilter.ClientId)}");
			}
			string token = RequestAccessToken(FindClientsScopes);
			IRestRequest request = PrepareJsonPostRequest(clientsFilter, FindClientsMethod, token);
			IRestResponse<List<ShortIdentityClientInfo>> response =
				RestClient.Post<List<ShortIdentityClientInfo>>(request);
			HandleRestClientError(response);
			return response.Data;
		}

		#endregion

	}

	#endregion

}

