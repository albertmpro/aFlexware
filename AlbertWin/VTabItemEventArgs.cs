﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Albert.Flex.Windows
{

	public delegate void VTabItemEventHandler(object sender, VTabItemEventArgs e);

	public class VTabItemEventArgs: RoutedEventArgs
	{
		public DocumentTabItem TabItem { get; set; }
	}
}
