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

namespace aFlexCode.View
{
	/// <summary>
	/// Interaction logic for WordPressPlugin.xaml
	/// </summary>
	public partial class WordPressPlugin : DocumentControl
	{
		public WordPressPlugin()
		{
			InitializeComponent();
		}

		public WordPressPlugin(TabControl _tab)
		{
			InitializeComponent();
		}

		public WordPressPlugin(TabControl _tab, string _fileName)
		{
			InitializeComponent();
		}

	}
}
