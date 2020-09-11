namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Common;
	using FileImport;
	using GeneratedWebFormService;
	using Core;
	using Core.Entities;

	#region Class: WebFormHandler

	/// <summary>
	/// Provied web form save handling.
	/// </summary>
	/// <seealso cref="Terrasoft.Configuration.IWebFormHandler" />
	public class WebFormHandler : IWebFormHandler
	{
		#region Fields: Private

		private readonly UserConnection _userConnection;

		#endregion

		#region Constructors

		public WebFormHandler(UserConnection userConnection) {
			_userConnection = userConnection;
		}

		public WebFormHandler(UserConnection userConnection, IWebFormImportParamsGenerator importParamsGenerator,
			IWebFormProcessHandlersFactory factory, FileImporter fileImporter) {
			_userConnection = userConnection;
			ImportParamsGenerator = importParamsGenerator;
			WebFormProcessHandlersFactory = factory;
			FileImporter = fileImporter;
		}

		#endregion

		#region Properties: Protected

		protected FormData FormData {
			get;
			set;
		}

		private IWebFormImportParamsGenerator _importParamsGenerator;
		protected IWebFormImportParamsGenerator ImportParamsGenerator {
			get {
				return _importParamsGenerator ?? (_importParamsGenerator = GetImportParamsGenerator());
			}
			set { _importParamsGenerator = value; }
		}

		private IWebFormProcessHandlersFactory _webFormProcessHandlersFactory;
		protected IWebFormProcessHandlersFactory WebFormProcessHandlersFactory {
			get {
				return _webFormProcessHandlersFactory ??
					(_webFormProcessHandlersFactory = new WebFormProcessHandlersFactory());
			}
			set { _webFormProcessHandlersFactory = value; }
		}

		private FileImporter _fileImporter;
		protected FileImporter FileImporter {
			get {
				return _fileImporter ??
					(_fileImporter = new FileImporter(_userConnection));
			}
			set { _fileImporter = value; }
		}


		private IEnumerable<IGeneratedWebFormPostProcessHandler> _listPostProcessHandlers;
		protected IEnumerable<IGeneratedWebFormPostProcessHandler> ListPostProcessHandlers {
			get {
				return _listPostProcessHandlers ?? (_listPostProcessHandlers = new List<IGeneratedWebFormPostProcessHandler>());
			}
			set { _listPostProcessHandlers = value; }
		}

		private IEnumerable<IGeneratedWebFormPreProcessHandler> _listPreProcessHandlers;
		protected IEnumerable<IGeneratedWebFormPreProcessHandler> ListPreProcessHandlers {
			get {
				return _listPreProcessHandlers ?? (_listPreProcessHandlers = new List<IGeneratedWebFormPreProcessHandler>());
			}
			set { _listPreProcessHandlers = value; }
		}

		#endregion

		#region Properties: Public

		public bool Success {
			get;
			private set;
		}

		public string ErrorMessage {
			get;
			private set;
		}

		public Exception Exception {
			get;
			private set;
		}

		#endregion

		#region Methods: Private

		private IWebFormImportParamsGenerator GetImportParamsGenerator() {
			var validator = new GeneratedWebFormValidator(_userConnection);
			var defaultValueManager = new ObjectDefaultValueManager();
			return new WebFormImportParamsGenerator(FormData, validator, defaultValueManager,
				_userConnection);
		}

		private IEnumerable<IGeneratedWebFormPostProcessHandler> GetPostProcessHandlers(Guid webFormId) {
			return WebFormProcessHandlersFactory.GetPostProcessHandlers(_userConnection, webFormId);
		}

		private IEnumerable<IGeneratedWebFormPreProcessHandler> GetPreProcessHandlers(Guid webFormId) {
			return WebFormProcessHandlersFactory.GetPreProcessHandlers(_userConnection, webFormId);
		}

		private void InitHandlers(Guid webFormId) {
			ListPreProcessHandlers = GetPreProcessHandlers(webFormId);
			ListPostProcessHandlers = GetPostProcessHandlers(webFormId);
		}

		private void SetErrorStatus(string message) {
			Success = false;
			ErrorMessage = message;
		}

		private void SetErrorStatus(string message, Exception exception) {
			SetErrorStatus(message);
			Exception = exception;
		}

		#endregion

		#region Methods: Protected

		protected void PostProcessData(FormData formData, Guid webFormId, Guid entityId) {
			ListPostProcessHandlers.ForEach(handler => {
				handler.Execute(_userConnection, webFormId, formData.formFieldsData, entityId);
			});
		}

		protected FormData PreProcessData(FormData formData) {
			ListPreProcessHandlers.ForEach(handler => {
				formData = handler.Execute(_userConnection, formData, ImportParamsGenerator);
			});
			return formData;
		}

		protected Guid SetUpNewEntityId(FormData formData) {
			Guid entityId = Guid.NewGuid();
			var values = formData.formFieldsData.ToList();
			FormFieldsData idData = values.FirstOrDefault(field => field.name.ToLower().Equals("id"));
			if (idData == null) {
				idData = new FormFieldsData {
					name = "Id",
					value = entityId.ToString()
				};
				values.Add(idData);
			} else {
				if (idData.value.IsValidGuid()) {
					entityId = Guid.Parse(idData.value);
				} else {
					idData.value = entityId.ToString();
				}
			}
			formData.formFieldsData = values.ToArray();
			return entityId;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Handles the form data.
		/// </summary>
		/// <param name="formData">The form data.</param>
		public void HandleForm(FormData formData) {
			Success = true;
			FormData = formData;
			Guid webFormId = WebFormHelper.GetWebFormId(formData);
			if (webFormId.Equals(Guid.Empty)) {
				SetErrorStatus(GeneratedWebFormLczUtilities
					.GetLczStringValue("UnknownWebFormIdentifierMessage",
						"WebFormHandler", _userConnection));
				return;
			}
			if (!(ImportParamsGenerator is IImportParamsGenerator)) {
				SetErrorStatus(GeneratedWebFormLczUtilities
					.GetLczStringValue("ImportParamsGeneratorImplementationMessage",
						"WebFormHandler", _userConnection));
				return;
			}
			InitHandlers(webFormId);
			Guid newEntityId = SetUpNewEntityId(formData);
			FormData = PreProcessData(formData);
			EntitySchema schema = WebFormHelper.GetWebFormEntitySchema(webFormId, _userConnection);
			ImportParameters parameters =
				((IImportParamsGenerator)ImportParamsGenerator).GenerateParameters(schema);
			if (!ImportParamsGenerator.Success) {
				SetErrorStatus(ImportParamsGenerator.ErrorMessage);
				return;
			}
			FileImporter.ImportEntitySaveError += (sender, args) => {
				SetErrorStatus(args.Message ?? args.Exception.Message, args.Exception);
			};
			FileImporter.ColumnProcessError += (sender, args) => {
				SetErrorStatus(args.Message);
			};
			FileImporter.ImportWithParams(parameters);
			if (Success) {
				PostProcessData(formData, webFormId, newEntityId);
			}
		}


		#endregion

	}

	#endregion

}

