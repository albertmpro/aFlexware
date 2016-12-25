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
using Albert.Flex.Runtime;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238
namespace aFlexLab.View
{
	/// <summary>
	/// The main start place for the Applicaton 
	/// </summary>
	public sealed partial class StartLab : Page10x
	{
		public StartLab()
		{
			this.InitializeComponent();

			//ViewModel Menu
			App.ViewModel.Menu.Visibility = Visibility.Visible;

		}

		void lab_Click(object sender, RoutedEventArgs e)
		{
			var push = sender as PushButton;

			switch (push.NavString)
			{
				case "sketch":
					// Go to the Sketch Lab
					App.ViewModel.Frame.Navigate(typeof(SketchLab));
					App.ViewModel.Notify("You are in the Sketch Lab.");
					break;
				case "theme":
					// Go to the Theme Lab
					App.ViewModel.Frame.Navigate(typeof(ThemeLab));
					App.ViewModel.Notify("You are in the Theme Lab.");
					break;
				case "img":
					// Go to the Image Lab
					App.ViewModel.Frame.Navigate(typeof(ImgLab));
					App.ViewModel.Notify("You are in the Img Lab.");
					break;
				case "browser":
					// Go to the Browser Lab
					App.ViewModel.Frame.Navigate(typeof(BrowserLab));
					App.ViewModel.Notify("You are in the Browser Lab.");
					break;
			}


		}


	}
}
