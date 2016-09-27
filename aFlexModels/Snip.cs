using System;
using System.Collections.Generic;
using System.Text;
using Albert.Flex;
namespace aFlexModels
{
    public class Snip: Notify 
    {
		string snipname, snip;

		/// <summary>
		/// Default Constructor 
		/// </summary>
		public Snip()
		{
			snip = "";
			snipname = "";
		}

		/// <summary>
		/// Build Contructor 
		/// </summary>
		/// <param name="_name"></param>
		/// <param name="_content"></param>
		public Snip(string _name, string _content)
		{
			snipname = _name;
			snip = _content;
		}


		/// <summary>
		/// Gets or set the name of the snip
		/// </summary>
		public string SnipName
		{
			get { return snipname; }
			set { snipname = value; OnPropertyChanged("SnipName"); }
		}


		/// <summary>
		/// Gets  or sets the content the snip 
		/// </summary>
		public string SnipContent
		{
			get { return snip; }
			set { snip = value; OnPropertyChanged("SnipContent"); }
		}

		public override string ToString()
		{
			return SnipContent;
		}


	}
}
