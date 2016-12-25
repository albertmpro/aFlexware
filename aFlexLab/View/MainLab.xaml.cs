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
using static Albert.Flex.Runtime.Device10x;
using static Albert.Flex.Runtime.QuickAnimation;
using Windows.UI;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace aFlexLab.View
{
	/// <summary>
	/// Main Lab
	/// </summary>
	public sealed partial class MainLab : Page10x
	{
		Color ac3 = (Color)App.Current.Resources["AccentColor3"];

		public MainLab()
		{
			this.InitializeComponent();


			//ViewModel Links 
			App.ViewModel.Menu = hamMenu; // Link to defualt hambuger menu 
			App.ViewModel.SplitView = splitView; // Link to the splitView
			App.ViewModel.Frame = frame; // Link to the frame 

			//Link to the StartLab 
			frame.Navigate(typeof(StartLab));


			//OnNotification lamba 
			App.ViewModel.OnNotification += (_message) =>
			{
				// Display the message 
				tbStatus.Text = _message;
				// Create an Animation for that message
				RunDouble(tbStatus, "Opacity", 1, .18, TimeSpan.FromSeconds(4.4));
			};

		}

		void ham_Click(object sender, RoutedEventArgs e)
		{
			var ham = sender as HamburgerButton;
			
			switch (ham.Label)
			{
				case "StartLab":
					
					// Navigate to the Start Lab
					App.ViewModel.Frame.Navigate(typeof(StartLab));
					//Let the Application know 
					App.ViewModel.Notify("You are in the Start Lab.");

					break;
				case "SketchLab":
					
					// Navigate to the Sketcvh Lab
					App.ViewModel.Frame.Navigate(typeof(SketchLab));
					//Let the Application know 
					App.ViewModel.Notify("You are in the Sketch Lab.");

					break;

				case "ThemeLab":
					
					//Navigate to the Theme Lab
					App.ViewModel.Frame.Navigate(typeof(ThemeLab));
					//Let the Application know 
					App.ViewModel.Notify("You are in the Theme Lab.");

					break;

				case "ImgLab":
					
					//Navigate to the Image Lab
					App.ViewModel.Frame.Navigate(typeof(ImgLab));
					//Let the Application know 
					App.ViewModel.Notify("You are in the Img Lab.");

					break;
				case "BrowserLab":

					//Navigate to the Browser Lab
					App.ViewModel.Frame.Navigate(typeof(BrowserLab));
					//Let the Application know 
					App.ViewModel.Notify("You are in the Browser Lab.");

					break;
			}

			//Close the Menu 
			splitView.IsPaneOpen = false;


		}





		protected override void OnNavigatedTo(NavigationEventArgs e)
		{
			base.OnNavigatedTo(e);

			TitleBarStyle(ac3, Colors.White);

		}

		void mnu_Click(object sender, RoutedEventArgs e)
		{
			splitView.IsPaneOpen = true;
		}
	}
}
