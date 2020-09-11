namespace Terrasoft.Configuration
{
	using System.IO;
	using System.ServiceModel;
	using System.ServiceModel.Activation;
	using System.ServiceModel.Web;
	using System.Web.SessionState;
	using Terrasoft.Configuration.FileUpload;
	using Terrasoft.Core;
	using Terrasoft.Core.Factories;
	using Terrasoft.Web.Common;
	using Terrasoft.Web.Common.ServiceRouting;
	using Terrasoft.Web.Http.Abstractions;

	#region Class: FileApiService

	[DefaultServiceRoute, SspServiceRoute]
	[ServiceContract]
	[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
	public class FileApiService : BaseService, IReadOnlySessionState
	{

		#region Properties: Private

		private FileRepository _fileRepository;

		/// <summary>
		/// File manager.
		/// </summary>
		private FileRepository FileRepository {
			get {
				if (_fileRepository == null) {
					_fileRepository = ClassFactory.Get<FileRepository>(
						new ConstructorArgument("userConnection", UserConnection));
				}
				return _fileRepository;
			}
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Uploads file.
		/// </summary>
		/// <param name="fileContents">File data stream.</param>
		/// <returns>Upload result.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "Upload", ResponseFormat = WebMessageFormat.Json)]
		public string Upload(Stream fileContent) {
			IFileUploadInfo fileUploadInfo = ClassFactory.Get<FileUploadInfo>(
				new ConstructorArgument("fileContent", fileContent),
#if NETSTANDARD2_0 // TODO CRM-46497
				new ConstructorArgument("request", HttpContext.Current.Request),
#else
				new ConstructorArgument("request", new System.Web.HttpRequestWrapper(System.Web.HttpContext.Current.Request)),
#endif
				new ConstructorArgument("storage", UserConnection.Workspace.ResourceStorage));
			if (FileRepository.UploadFile(fileUploadInfo)) {
				return "Ok";
			}
			return string.Empty;
		}

		#endregion

	}

	#endregion

}
