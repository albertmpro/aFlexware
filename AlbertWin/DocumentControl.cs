using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Albert.Flex.Windows
{
	/// <summary>
	/// A special ContentControl designed to deal with handling documents. 
	/// </summary>
	public class DocumentControl : ContentControl
	{
		public DocumentControl()
		{
			//Do nothing 
		}

		protected DocumentControl(TabControl _mainTab,string _title,Action _init)
		{
			_init();
			if (_mainTab != null)
			{
				TabItem = new DocumentTabItem(_title, true, this, _mainTab);
			}
		}
		protected DocumentControl(TabControl _mainTab, string _title, bool _isCloseEnabled,Action _init)
		{
			_init();
			if (_mainTab != null)
			{
				TabItem = new DocumentTabItem(_title, _isCloseEnabled, this, _mainTab);
			}
		}


		/// <summary>
		/// Gets or sets a Page that ueses the DocumentControl
		/// </summary>
		public Page Page { get; set; }

		/// <summary>
		/// Gets or sets the TabItem that uses the DocumentControl 
		/// </summary>
		public DocumentTabItem TabItem { get; set; }


		/// <summary>
		/// Gets or sets the TabControl that uses the DocumentControl 
		/// </summary>
		public TabControl MainTabControl { get; set; }

		public string CurrentFile { get; set; }

		public FileInfo FileInfo { get; set; }

		public static int Count { get; set; } = 1;


	}
}
