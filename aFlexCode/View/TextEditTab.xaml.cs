using Albert.Flex.Windows;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace aFlexCode.View
{
	/// <summary>
	/// Interaction logic for TextEditTab.xaml
	/// </summary>
	public partial class TextEditTab : DocumentControl
	{
		//Field's
		public CodeEditor txt1; //Default CodeEditor 
	 	CodeEditor txt2, txt3; //Split code editor's 
		GridSplitter split1, split2;
		ColumnDefinition col1, col2, col3, col4, col5;

		/// <summary>
		/// Default Constructor 
		/// </summary>
		/// <param name="_tab"></param>
		public TextEditTab(TabControl _tab)
		{
			InitializeComponent();



			//Setup the Text Document 
			TabItem = new DocumentTabItem($"TextFile{Count++}",true, this, _tab);

			busyWork();
			column1();

			TabItem.Focus();
			txt1.Focus();
		}
		public TextEditTab(TabControl _tab,string _fileName)
		{
			InitializeComponent();

			//Setup FileInfo 
			FileInfo = new FileInfo(_fileName);

			//Create the TabItem
			TabItem = new DocumentTabItem(FileInfo.Name, true, this, _tab);

			busyWork();
			column1();

	
			//Setup the Text Document 
			
			txt1.Text = File.ReadAllText(_fileName);
			TabItem.Focus();
			txt1.Focus();
			
		}



		void busyWork()
		{

			//TabItem Closed Lamba 
			TabItem.Closed +=  (sender, e) =>
			{
				var msg = MessageBox.Show("Do you want to close this tab?", "About to Close", MessageBoxButton.YesNo, MessageBoxImage.Hand);

				if (msg == MessageBoxResult.Yes)
				{
					TabItem.MainTab.Items.Remove(TabItem);
				}
				else if (msg == MessageBoxResult.No)
				{
					// Do nothing 
				}
			};			

			//TextEditor's
			txt1 = new CodeEditor(TabItem);
			txt2 = new CodeEditor();
			txt3 = new CodeEditor();

			//Grid Spliter 
			split1 = new GridSplitter { Width = 5, Background = Brushes.White };
			split2 = new GridSplitter { Width = 5, Background = Brushes.White };

			//Column Defnition 
			col1 = new ColumnDefinition(); // First TextEditor 
			col2 = new ColumnDefinition { MinWidth = 10 }; // Grid Spliter
			col3 = new ColumnDefinition();// Second TextEditor
			col4 = new ColumnDefinition { MinWidth = 10 }; //Grid Spliter 
			col5 = new ColumnDefinition();// Third Text Editor 

		}

		void column1()
		{
			layoutRoot.Children.Clear();
			layoutRoot.ColumnDefinitions.Clear();
			layoutRoot.ColumnDefinitions.Add(col1);

			//Set Columns 
			Grid.SetColumn(txt1, 0);


			//Add the first TextEditor 
			layoutRoot.Children.Add(txt1);
		}

		void column2()
		{
			layoutRoot.Children.Clear();
			layoutRoot.ColumnDefinitions.Clear();

			layoutRoot.ColumnDefinitions.Add(col1);
			layoutRoot.ColumnDefinitions.Add(col2);
			layoutRoot.ColumnDefinitions.Add(col3);
			
			//Set Columns 
			Grid.SetColumn(txt1, 0);
			Grid.SetColumn(split1, 1);
			Grid.SetColumn(txt1, 2);

			//Add the first TextEditor 
			layoutRoot.Children.Add(txt1);
			layoutRoot.Children.Add(split1);
			layoutRoot.Children.Add(txt2);


		}




		void column3()
		{
			layoutRoot.Children.Clear();
			layoutRoot.ColumnDefinitions.Clear();

			layoutRoot.ColumnDefinitions.Add(col1);
			layoutRoot.ColumnDefinitions.Add(col2);
			layoutRoot.ColumnDefinitions.Add(col3);
			layoutRoot.ColumnDefinitions.Add(col4);
			layoutRoot.ColumnDefinitions.Add(col5);

			//Set Columns 
			Grid.SetColumn(txt1, 0);
			Grid.SetColumn(split1, 1);
			Grid.SetColumn(txt1, 2);
			Grid.SetColumn(split1, 3);
			Grid.SetColumn(txt3, 4);

			//Add the first TextEditor 
			layoutRoot.Children.Add(txt1);
			layoutRoot.Children.Add(split1);
			layoutRoot.Children.Add(txt2);
			layoutRoot.Children.Add(split2);
			layoutRoot.Children.Add(txt3);


		}

		

	}
}
