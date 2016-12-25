using Albert.Flex.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Xceed.Wpf.Toolkit;
namespace aFlexCode.View
{
	/// <summary>
	/// Interaction logic for NewItemWindow.xaml
	/// </summary>
	public partial class NewItemWindow : ChildWindow
	{
		public NewItemWindow()
		{
			InitializeComponent();
		}



		void Button_Click(object sender, RoutedEventArgs e)
		{
			var push = sender as PushButton;

			switch (push.NavString)
			{
				case "ok":

					var tab = App.ViewModel.Tab;
					if (radText.IsChecked == true)
					{
						//Create a TextEditor Tab 
					 	var txt = new TextEditTab(tab);
					}
					else if (radSS.IsChecked == true)
					{
						//Create a StyleSheet Tab
						var ss = new StylesheetTab(tab);
					}
					else if (radWPTheme.IsChecked == true)
					{
						//Create a WordPress Theme Tab
						var wpt = new WordPressThemeTab(tab);
					}
					else if (radWPPlugin.IsChecked == true)
					{
						//Create a WordPress Plugin Tab 
						var wpp = new WordPressPlugin(tab);
					}
					else if (radWs.IsChecked == true)
					{
						//Create a Web Starter Tab 
						var ws = new WebsiteStarterTab(tab);
					}

					Close();
					break;
				case "cancel":
					Close();
					break;
			} 
		}


	}
}
