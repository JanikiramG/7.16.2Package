namespace Terrasoft.Configuration.Reporting.FastReport
{
	using System;
	using Terrasoft.Core.Factories;

	#region Class: FastReportDataSourceDataProviderResolver

	public class FastReportDataSourceDataProviderResolver : IFastReportDataSourceDataProviderResolver
	{

		#region Methods: Public

		public IFastReportDataSourceDataProvider Resolve(string providerName) {
			if (!ClassFactory.TryGet<IFastReportDataSourceDataProvider>(providerName, out var provider)) {
				throw new Exception();
			}
			return provider;
		}

		#endregion

	}

	#endregion

}

