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
	/// Interaction logic for StartTab.xaml
	/// </summary>
	public partial class ProjectTab : DocumentControl
	{


		public ProjectTab(TabControl _tab)
		{
			InitializeComponent();

			//Setup the Tab Item 
			TabItem = new DocumentTabItem("Start Tab", false, this, _tab);
		}


		//Main Click funciton 
		void push_Click(object sender, RoutedEventArgs e)
		{
			var push = sender as PushButton;

			switch(push.NavString)
			{
				case "txt":
					//Create a new Text Document 
					var txt = new TextEditTab(App.ViewModel.Tab);
					break;
				default:

					break;
			}
		}




	}
}
