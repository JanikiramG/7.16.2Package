namespace Terrasoft.Configuration.EmailsSearch
{

	using System.Collections.Generic;
	using Terrasoft.Configuration.GlobalSearch;

	#region Interface: IESEmailManager

	public interface IESEmailManager
	{
		
		#region Methods: Public

		IEnumerable<Dictionary<string, string>> SearchEmails(List<string> request);

		#endregion

	}

	#endregion

}
