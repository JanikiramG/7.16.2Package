namespace Terrasoft.Configuration.FileUpload
{
	using System;
	using System.Collections.Generic;
	using System.Collections.Specialized;
	using System.IO;
	using System.Text.RegularExpressions;
	using Newtonsoft.Json;
	using Terrasoft.Common;
	using Terrasoft.WebApp;

#if NETSTANDARD2_0 // TODO CRM-46497
	using TS = Terrasoft.Web.Http.Abstractions;
#else
	using MS = System.Web;
#endif
	#region Class: FileUploadInfo

	public class FileUploadInfo : IFileUploadInfo
	{

		#region Constants: Private

		private const string HeaderContentRange = "Content-Range";
		private const string HeaderRange = "Range";

		#endregion

		#region Fields: Private
#if NETSTANDARD2_0 // TODO CRM-46497
		private TS.HttpRequest _request;
		private TS.RequestDataCollection _queryString;
#else
		private MS.HttpRequestBase _request;
		private NameValueCollection _queryString;
#endif
		private Stream _fileContent;
		private IResourceStorage _storage;

		/// <summary>
		/// Regular expression for the first chunk.
		/// </summary>
		private Regex _firstChunkRegex = new Regex(@"^\D*0");

		#endregion

		#region Constructors: Public
#if NETSTANDARD2_0 // TODO CRM-46497
		public FileUploadInfo(Stream fileContent, TS.HttpRequest request, IResourceStorage storage) {
			_request = request;
			_fileContent = fileContent;
			_storage = storage;
		}
#else
		public FileUploadInfo(Stream fileContent, MS.HttpRequestBase request, IResourceStorage storage) {
			_request = request;
			_fileContent = fileContent;
			_storage = storage;
		}
#endif
		#endregion

		#region Properties: Protected
#if NETSTANDARD2_0 // TODO CRM-46497
		protected TS.RequestDataCollection QueryString {
			get => _queryString 
				?? (_queryString = IsChunkedUpload 
					? (TS.RequestDataCollection) _request.QueryString
					: _request.Form
				);
		}
#else
		protected NameValueCollection QueryString {
			get {
				if (_queryString == null) {
					_queryString = IsChunkedUpload ? _request.QueryString : _request.Form;
				}
				return _queryString;
			}
		}
#endif
		#endregion

		#region Properties: Public

		/// <summary>
		/// File entity schema name.
		/// </summary>
		public string EntitySchemaName {
			get {
				return QueryString["entitySchemaName"];
			}
		}

		/// <summary>
		/// Data entity schema column name.
		/// </summary>
		public string ColumnName {
			get {
				return QueryString["columnName"];
			}
		}

		/// <summary>
		/// File name.
		/// </summary>
		public string FileName {
			get {
				if (!IsChunkedUpload) {
					return _request.Files["files"].FileName;
				} else {
					return QueryString["fileName"];
				}
			}
		}

		/// <summary>
		/// File identifier.
		/// </summary>
		public Guid FileId {
			get {
				return new Guid(QueryString["fileId"]);
			}
		}

		/// <summary>
		/// File type identifier.
		/// </summary>
		public virtual Guid TypeId {
			get {
				string fileTypeId = QueryString["fileTypeId"];
				if (string.IsNullOrEmpty(fileTypeId)) {
					return FileConsts.FileTypeUId;
				} else {
					return new Guid(fileTypeId);
				}
			}
		}

		/// <summary>
		/// Total file length.
		/// </summary>
		public decimal TotalFileLength {
			get {
				decimal totalFileLength = 0;
				string totalFileLengthString = QueryString["totalFileLength"];
				if (!decimal.TryParse(totalFileLengthString, out totalFileLength)) {
					throw new InvalidFileSizeException(_storage);
				}
				return totalFileLength;
			}
		}

		/// <summary>
		/// Parent column name.
		/// </summary>
		public string ParentColumnName {
			get {
				return QueryString["parentColumnName"];
			}
		}

		/// <summary>
		/// Parent column value.
		/// </summary>
		public Guid ParentColumnValue {
			get {
				return new Guid(QueryString["parentColumnValue"]);
			}
		}

		/// <summary>
		/// File content.
		/// </summary>
		public Stream Content {
			get {
				if (!IsChunkedUpload) {
					return _request.Files["files"].InputStream;
				} else {
					byte[] fileContentBytes = new byte[_request.TotalBytes];
					_fileContent.Read(fileContentBytes, 0, fileContentBytes.Length);
					return new MemoryStream(fileContentBytes);
				}
			}
		}

		/// <summary>
		///  Additional parameters.
		/// </summary>
		public Dictionary<string, object> AdditionalParams {
			get {
				var value = new Dictionary<string, object>();
				string additionalParams = QueryString["AdditionalParams"];
				if (additionalParams.IsNotNullOrEmpty()) {
					value = JsonConvert.DeserializeObject<Dictionary<string, object>>(additionalParams);
				}
				return value;
			}
		}

		/// <summary>
		/// Determines if it is chunked upload.
		/// </summary>
		public bool IsChunkedUpload {
			get {
				return !string.IsNullOrEmpty(ByteRange);
			}
		}

		/// <summary>
		/// Byte range.
		/// </summary>
		/// <remarks>Range examples: 0-, 123-456. Content range example: 123-456/789.</remarks>
		public string ByteRange {
			get {
				string value = _request.Headers[HeaderRange];
				if (string.IsNullOrEmpty(value)) {
					value = _request.Headers[HeaderContentRange];
				}
				return value;
			}
		}

		/// <summary>
		/// File version.
		/// </summary>
		public int Version {
			get {
				return 1;
			}
		}

		/// <summary>
		/// Determines if it is first chunk.
		/// </summary>
		public bool IsFirstChunk {
			get {
				return _firstChunkRegex.IsMatch(ByteRange);
			}
		}

		#endregion
	}

	#endregion
}
