using System;
using System.Collections.Generic;
using System.Text;
using Albert.Flex;
namespace aFlexRuntime
{
    public class WebUrl: Notify
    {
		string url, label; 


		public string Url
		{
			get { return url; }
			set { url = value;  OnPropertyChanged("Url"); }
		}

		public string Label
		{
			get { return label; }
			set { label = value; OnPropertyChanged("Label"); }
		}


	}
}
