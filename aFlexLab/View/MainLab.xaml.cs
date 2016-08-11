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
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class MainLab : Page10x
	{
		Color ac3 = (Color)App.Current.Resources["AccentColor3"];

		public MainLab()
		{
			this.InitializeComponent();

			//Link to the StartLab 
			frame.Navigate(typeof(StartLab));

			//ViewModel Links 
			App.ViewModel.Menu = hamMenu; // Link to defualt hambuger menu 
			App.ViewModel.SplitView = splitView; // Link to the splitView
			App.ViewModel.Frame = frame; // Link to the frame 
			App.ViewModel.OnNotification += notify;


			//App.ViewModel.Notify("Welcome to the aFlexLab!");

		}


		/// <summary>
		/// Notify Message 
		/// </summary>
		/// <param name="_message"></param>
		void notify(string _message)
		{
			//Display the message 
			tbStatus.Text = _message;
			// Create an Animation for that message
			RunDouble(tbStatus, "Opacity", 1, .18, TimeSpan.FromSeconds(4.4));
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
