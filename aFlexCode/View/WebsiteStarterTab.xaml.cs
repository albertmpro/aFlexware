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
using Albert.Flex.Windows;
namespace aFlexCode.View
{
	/// <summary>
	/// Interaction logic for WebsiteStarterTab.xaml
	/// </summary>
	public partial class WebsiteStarterTab : DocumentControl
	{

		public WebsiteStarterTab()
		{
			InitializeComponent();
		}
		public WebsiteStarterTab(TabControl _tab)
		{
			InitializeComponent();
		}
		public WebsiteStarterTab(TabControl _tab,string _fileName)
		{
			InitializeComponent();
		}


	}
}
