﻿using System;
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
using static Albert.Flex.Windows.Win32IO;
namespace aFlexCode.View
{
	/// <summary>
	/// Interaction logic for TabView.xaml
	/// </summary>
	public partial class TabView : Page
	{
		ProjectTab project;
		public TabView()
		{
			InitializeComponent();
			//Create a Project Tab 
			project = new ProjectTab(tabControl);

			//Link to the ViewModel 
			App.ViewModel.Tab = tabControl;

		
		}

	

	}
}
