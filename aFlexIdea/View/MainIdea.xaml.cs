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
using Windows.Devices;
using Windows.UI.Xaml.Navigation;
using Albert.Flex.Runtime;
using static Albert.Flex.Runtime.QuickAnimation;
using Windows.Phone.UI.Input;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace aFlexIdea.View
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class MainIdea : Page10x
	{

		public MainIdea()
		{
			this.InitializeComponent();

			//Link the Frame 
			frame.Navigate(typeof(StartIdea));


			//Link to the ViewModel 
			App.ViewModel.Frame = frame; // Frame 
			App.ViewModel.Menu = hamMenu; // Menu 
			App.ViewModel.SplitView = splitView; //splitView


			//Notify Lamba 
			App.ViewModel.OnNotification += (str) =>
			{
				//Link the message 
				tbStatus.Text = str;
				//Create a quick Animation 
				RunDouble(tbStatus, "Opacity", 1, .25, TimeSpan.FromSeconds(4.4));



			};

			//Notify you have enter the application 
			App.ViewModel.Notify("Welcome to aFLexIdea");



		}


		protected override void OnNavigatedTo(NavigationEventArgs e)
		{
			base.OnNavigatedTo(e);
			Orientation(Windows.Graphics.Display.DisplayOrientations.Portrait);
			HardwareButtons.BackPressed += On_PhoneGoBack;

		}

		protected override void OnNavigatingFrom(NavigatingCancelEventArgs e)
		{
			base.OnNavigatingFrom(e);
			HardwareButtons.BackPressed -= On_PhoneGoBack;

		}





		void menu_OpenClick(object sender, RoutedEventArgs e)
		{
			splitView.IsPaneOpen = true;
		}
	}
}
