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
using Windows.Phone.UI.Input;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace aFlexIdea.View
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class StoryboardIdea : Page10x
	{
		public StoryboardIdea()
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

		void cmd_Click(object sender, RoutedEventArgs e)
		{
			var cmd = sender as CmdButton;

			switch(cmd.Label)
			{
				case "Draw":
					setSkState(SketchState.Draw, "Draw");
					break;
				case "Line":
					setSkState(SketchState.Line, "Line");
					break;
				case "Rectangle":
					setSkState(SketchState.Rectangle, "Rectangle");
					break;
				case "Circle":
					setSkState(SketchState.Circle, "Circle");
					break;


				default:

					break;
			}
		}


		void setSkState(SketchState _sketch, string _msg)
		{
			sketchCanvas.SketchState = _sketch;
			App.ViewModel.Notify(_msg);
		}


		private void txt_GotFocus(object sender, RoutedEventArgs e)
		{
			txt.SelectAll();
			
		}
	}

	}
