using System;
using System.Collections.Generic;
using System.Text;
using Albert.Flex;
namespace aFlexModels
{
	public class WebUrl : Notify
	{
		string url, name;

		/// <summary>
		/// Default Constructor 
		/// </summary>
		public WebUrl()
		{
			url = "";
			name = "";
		}

		public WebUrl(string _url, string _name)
		{
			url = _url; // define the Url 
			name = _name; // Define the Name
		}
		public WebUrl(string _url)
		{
			name = $"Name{count++}"; // Make up name 
			url = _url; // Get the url 
		}

		static int count { get; set; } = 1; 

    }
}
