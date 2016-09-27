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
using static Albert.Flex.Windows.QuickAnimation;
using static Albert.Flex.Windows.Win32IO;
namespace aFlexCode.View
{
	/// <summary>
	/// Main Shell for the Applcation 
	/// </summary>
	public partial class MainShell : ViewShell
	{

		//Field's TabView 
		TabView tabView;
	
		public MainShell()
		{
			InitializeComponent();

			//Create the tabView 
			tabView = new TabView();
			//Navigate to the tabView  
			frame.Navigate(tabView);


			//Link your command bindings 
			CommandBindings.Add(new CommandBinding(ApplicationCommands.New, New_Command));

			//Link your command bindings 
			CommandBindings.Add(new CommandBinding(ApplicationCommands.Open, Open_Command));



			//Quit Command Lamba 
			CommandBindings.Add(new CommandBinding(DesktopCommands.Quit, (sender, e) =>
			 {
				 //Close the Window 
				 Close();
			 }));


			//Notify Lamba  
			App.ViewModel.OnNotification += (str) =>
			{
				// Set the tbStatus value 
				tbStatus.Text = str;
				// Create an Animation Quiclky 
				RunDouble(tbStatus, "Opacity", 1, .3, TimeSpan.FromSeconds(4.3));
			};

			//Send a Message 
			App.ViewModel.Notify("Hello World");



		}



		void New_Command(object sender, ExecutedRoutedEventArgs e)
		{
			//Message Box
			var msg = MessageBox.Show("Do you want to create a new Document", "New Document", MessageBoxButton.YesNo, MessageBoxImage.Hand);

			if (msg == MessageBoxResult.Yes)
			{
				var t = new TextEditTab(App.ViewModel.Tab);
				//Notify the Application 
				App.ViewModel.Notify("You have created a new Document.");
			}
			else if (msg == MessageBoxResult.No)
			{
				// Do nothing 
			}
		}


		void Open_Command(object sender, ExecutedRoutedEventArgs e)
		{

			//Create an OpenDialog Lamba 
			OpenDialogTask("Open a Text File", App.ViewModel.TextFilter, (d) =>
			{
				//Link to the Tab 
				var txtTab = new TextEditTab(App.ViewModel.Tab, d.FileName);

			});

		}


		void Export_StyeSheet(object sender, ExecutedRoutedEventArgs e)
		{

		}

		void Export_WebStarter(object sender, ExecutedRoutedEventArgs e)
		{

		}

		void Export_WordPressTheme( object sender ,ExecutedRoutedEventArgs e)
		{

		}
		void Export_WordPressPlugIn(object sender, ExecutedRoutedEventArgs e)
		{

		}

	}
}
