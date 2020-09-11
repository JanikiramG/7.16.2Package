namespace Terrasoft.Configuration.FileService
{
	using System;
	using System.Globalization;
	using System.IO;
	using System.ServiceModel;
	using System.ServiceModel.Activation;
	using System.ServiceModel.Web;
	using System.Text.RegularExpressions;
	using System.Web.SessionState;
	using Terrasoft.Common;
	using Terrasoft.Configuration.FileUpload;
	using Terrasoft.Core.Factories;
	using Terrasoft.Web.Common;
	using Terrasoft.Web.Http.Abstractions;
	using HttpUtility = System.Web.HttpUtility;

	#region Class: FileService

	[ServiceContract]
	[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
	public class FileService : BaseService, IReadOnlySessionState
	{

		#region Properties: Private

		private FileRepository _fileRepository;

		/// <summary>
		/// File manager.
		/// </summary>
		private FileRepository FileRepository =>
			_fileRepository ?? (_fileRepository = ClassFactory.Get<FileRepository>(
				new ConstructorArgument("userConnection", UserConnection)));

		private HttpContext CurrentContext => HttpContextAccessor.GetInstance();

		#endregion

		#region Methods: Private

		/// <summary>
		/// Remove special characters from fileName.
		/// </summary>
		/// <param name="fileName">File name.</param>
		/// <returns>File name without special characters.</returns>
		private string RemoveSpecialCharacters(string fileName) {
			return Regex.Replace(fileName, @"[^a-zA-Z\p{IsCyrillic}0-9_.,^&@£$€!½§~'=()\[\]{} «»<>~#*%+-]+",
				"_", RegexOptions.Compiled);
		}

		#endregion

		#region Methods: Protected

		/// <summary>
		/// Gets response content disposition header value.
		/// </summary>
		/// <param name="fileName">File name.</param>
		/// <returns>Content disposition header value.</returns>
		protected virtual string GetResponseContentDisposition(string fileName) {
			string processedFileName;
			HttpRequest request = CurrentContext.Request;
			string userAgent = (request.UserAgent ?? String.Empty).ToLowerInvariant();
			if (userAgent.Contains("android")) {
				processedFileName = $"filename=\"{RemoveSpecialCharacters(fileName)}\"";
			} else if (userAgent.Contains("safari")) {
				processedFileName = $"filename*=UTF-8''{HttpUtility.UrlEncode(fileName)}";
			} else {
				processedFileName = $"filename=\"{fileName}\"; filename*=UTF-8''{HttpUtility.UrlEncode(fileName)}";
			}
			return $"attachment; {processedFileName}";
		}

		/// <summary>
		/// Sets outgoing response content length.
		/// </summary>
		protected virtual void SetOutgoingResponseContentLength(int size) {
			CurrentContext.Response.Headers["Content-Length"] = size.ToString(CultureInfo.InvariantCulture);
		}

		/// <summary>
		/// Sets outgoing response content type.
		/// </summary>
		protected virtual void SetOutgoingResponseContentType() {
			CurrentContext.Response.ContentType = "application/octet-stream";
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Load file
		/// </summary>
		/// <param name="entitySchemaUId">EntitySchema UId</param>
		/// <param name="fileId">File Id</param>
		[OperationContract]
		[WebGet(UriTemplate = "GetFile/{entitySchemaUId}/{fileId}")]
		public void GetFile(string entitySchemaUId, string fileId) {
			using (var memoryStream = new MemoryStream()) {
				SetOutgoingResponseContentType();
				IFileUploadInfo fileInfo = FileRepository.LoadFile(new Guid(entitySchemaUId),
					new Guid(fileId), new BinaryWriter(memoryStream));
				if (fileInfo == null) {
					return;
				}
				SetOutgoingResponseContentLength(Convert.ToInt32(fileInfo.TotalFileLength));
				string contentDisposition = GetResponseContentDisposition(fileInfo.FileName);
				CurrentContext.Response.AddHeader("Content-Disposition", contentDisposition);
				MimeTypeResult mimeTypeResult = MimeTypeDetector.GetMimeType(fileInfo.FileName);
				CurrentContext.Response.ContentType = mimeTypeResult.HasError
					? "application/octet-stream"
					: mimeTypeResult.Type;
				memoryStream.Flush();
				memoryStream.WriteTo(CurrentContext.Response.OutputStream);
			}
		}

		#endregion
	}

	#endregion
}

