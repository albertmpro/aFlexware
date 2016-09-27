using Albert.Flex.Runtime;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Phone.UI.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace aFlexIdea.View
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class StartIdea : Page10x
	{
		public StartIdea()
		{
			this.InitializeComponent();
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

		void hyp_Link(object sender, RoutedEventArgs e)
		{
			var hype = sender as HyperlinkButton; 

			switch(hype.Tag.ToString())
			{
				case "storyboard":
					App.ViewModel.Frame.Navigate(typeof(StoryboardIdea));
					App.ViewModel.Menu.Visibility = Visibility.Collapsed;
					break;
				default:

					break;


			}

		}


	}
}
