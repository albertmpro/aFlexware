using Albert.Flex.Runtime;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace aFlexLab.View
{
	public sealed partial class QuickTheme : UserControl
	{
		public QuickTheme()
		{
			this.InitializeComponent();

			colorPicker.OnColorChanged += (c) =>
			{
				//Default Brush 
				var brush = new SolidColorBrush(c);
				


				if (opt1.IsChecked == true)
				{
					opt1.Background = brush;
					colorPicker.ColorHistory.Add(new ColorModel(brush.Color));

				}
				else if (opt2.IsChecked == true)
				{
					opt2.Background = brush;
					colorPicker.ColorHistory.Add(new ColorModel(brush.Color));

				}
				else if (opt3.IsChecked == true)
				{
					opt3.Background = brush;
					colorPicker.ColorHistory.Add(new ColorModel(brush.Color));
				}
				else if (opt4.IsChecked == true)
				{
					opt4.Background = brush;
					colorPicker.ColorHistory.Add(new ColorModel(brush.Color));

				}
				else if (opt5.IsChecked == true)
				{
					opt5.Background = brush;
					colorPicker.ColorHistory.Add(new ColorModel(brush.Color));
				}
		

			};

		}

		private void opt_Checked(object sender, RoutedEventArgs e)
		{
			var opt = sender as OptionButton;

			if(opt.IsChecked == true)
			{
				opt.BorderBrushChecked = opt.Background;
			}

		}

		
	}
}
