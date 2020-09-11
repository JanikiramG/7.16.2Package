namespace Terrasoft.Configuration.Reporting.FastReportEngine
{
	using Terrasoft.Reporting.FastReport.Connection;
	using Terrasoft.Web.Common;

	#region Class: FastReportAppEventListener

	public class FastReportAppEventListener : AppEventListenerBase
	{

		#region Methods: Public

		public override void OnAppStart(AppEventContext context) {
			base.OnAppStart(context);
			ReportDataSourceConnectionInitializer.Initialize();
		}

		#endregion

	}

	#endregion

}

