namespace Terrasoft.Configuration.Reporting.FastReportEngine
{
	using System;
	using System.Threading.Tasks;
	using Terrasoft.Configuration.Reporting.FastReport;
	using Terrasoft.Core;
	using Terrasoft.Reporting.FastReport.Abstractions;

	#region Class: FastReportTemplateProvider

	public class FastReportTemplateProvider : IReportTemplateProvider
	{

		#region Fields: Private

		private readonly FastReportTemplateManager _templateManager;

		#endregion

		#region Constructors: Public

		public FastReportTemplateProvider(UserConnection userConnection) {
			_templateManager = new FastReportTemplateManager(userConnection);
		}

		#endregion

		#region Methods: Public

		public Task<string> Get(Guid templateId) {
			var template = _templateManager.GetTemplate(templateId);
			return Task.FromResult(template);
		}

		#endregion

	}

	#endregion

}

