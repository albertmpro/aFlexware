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
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class StartLab : Page10x
	{
		public StartLab()
		{
			this.InitializeComponent();

			//Pivot Selection Lamba 
			pivot.SelectionChanged += (sender, e) =>
			{
				switch(pivot.SelectedIndex)
				{
					case 0:
						App.ViewModel.Notify("Quick Launch");
						break;
					case 1:
						App.ViewModel.Notify("Quick Theme");
						break;
					case 2:
						App.ViewModel.Notify("Quick Sketch");
						break;
					default:

						break;
						

				}
			};
		}
	}
}
