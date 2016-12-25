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
	/// Interaction logic for StylesheetTab.xaml
	/// </summary>
	public partial class StylesheetTab : DocumentControl
	{
		public StylesheetTab()
		{
			InitializeComponent();
		}

		public StylesheetTab(TabControl _tab)
		{
			InitializeComponent();
			//Create the TabItem here 
			TabItem = new DocumentTabItem($"Styleshet{Count++}", true,this, _tab);
			//Focus on the tab item 
			TabItem.Focus();
			txtName.Focus();
		}

		public StylesheetTab(TabControl _tab,string _fileName)
		{
			InitializeComponent();
		}

		private void colorPicker_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
		{
			var brush = new SolidColorBrush(Color.FromRgb(colorPicker.R,colorPicker.G,colorPicker.B));
			if(theme.opt1.IsChecked == true)
			{
				colorPicker.SelectedColor = theme.brush1.Color;
				theme.brush1 = brush;
			}
			else if (theme.opt2.IsChecked == true)
			{
				colorPicker.SelectedColor = theme.brush1.Color;
				theme.brush2 = brush;
			}
			else if (theme.opt3.IsChecked == true)
			{
				colorPicker.SelectedColor = theme.brush1.Color;
				theme.brush3 = brush;
			}
			else if (theme.opt4.IsChecked == true)
			{
				colorPicker.SelectedColor = theme.brush1.Color;
				theme.brush4 = brush;
			}
			else if (theme.opt5.IsChecked == true)
			{
				colorPicker.SelectedColor = theme.brush1.Color;
				theme.brush5 = brush;
			}
		}
	}
}
