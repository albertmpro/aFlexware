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
	/// Interaction logic for FiveTheme.xaml
	/// </summary>
	public partial class FiveTheme : UserControl
	{
		public FiveTheme()
		{
			InitializeComponent();
		}

		void opt_Click(object sender, RoutedEventArgs e)
		{
			var opt = sender as OptionButton;

			opt.BorderBrushChecked = opt.Background;

		}

	}
}
