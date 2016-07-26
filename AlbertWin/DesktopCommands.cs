using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
namespace Albert.Flex.Windows
{
	public static class DesktopCommands
	{
		private static RoutedUICommand startview, about, options, saveas, quit, zoomin, zoomout, draw, line, erase, clear,refreshtextfile,snips;

		static DesktopCommands()
		{

			startview = new RoutedUICommand("StartView", "StartView", typeof(DesktopCommands));
			startview.InputGestures.Add(new KeyGesture(Key.N, ModifierKeys.Control | ModifierKeys.Shift, "Ctrl+Shift+N"));


			about = new RoutedUICommand("About", "About", typeof(DesktopCommands));
			about.InputGestures.Add(new KeyGesture(Key.A, ModifierKeys.Alt, "Alt+A"));


			saveas = new RoutedUICommand("SaveAs", "SaveAs", typeof(DesktopCommands));
			saveas.InputGestures.Add(new KeyGesture(Key.S, ModifierKeys.Control | ModifierKeys.Shift, "Ctrl+Shift+S"));

			quit = new RoutedUICommand("Quit", "Quit", typeof(DesktopCommands));
			quit.InputGestures.Add(new KeyGesture(Key.Q, ModifierKeys.Control, "Ctrl+Q"));

			zoomin = new RoutedUICommand("ZoomIn", "ZoomIn", typeof(DesktopCommands));
			zoomin.InputGestures.Add(new KeyGesture(Key.OemPlus, ModifierKeys.Control, "Ctrl+"));

			zoomout = new RoutedUICommand("ZoomOut", "ZoomOut", typeof(DesktopCommands));
			zoomout.InputGestures.Add(new KeyGesture(Key.OemMinus, ModifierKeys.Control, "Ctrl-"));

			refreshtextfile = new RoutedUICommand("RefreshTextFile", "RefreshTextFile", typeof(DesktopCommands));
			refreshtextfile.InputGestures.Add(new KeyGesture(Key.R, ModifierKeys.Alt, "Alt+P"));

			snips = new RoutedUICommand("Snips", "Snips", typeof(DesktopCommands));
			snips.InputGestures.Add(new KeyGesture(Key.Space, ModifierKeys.Control));

			draw = new RoutedUICommand("Draw", "Draw", typeof(DesktopCommands));

			line = new RoutedUICommand("Line", "Line", typeof(DesktopCommands));

			erase = new RoutedUICommand("Erase", "Erase", typeof(DesktopCommands));

			clear = new RoutedUICommand("Clear", "Clear", typeof(DesktopCommands));

			options = new RoutedUICommand("Options", "Options", typeof(DesktopCommands));

		}

		public static RoutedUICommand Snips { get { return snips; } }

		public static RoutedUICommand RefreshTextFile
		{
			get
			{
				return refreshtextfile;
			}
		}

		public static RoutedUICommand StartView
		{
			get
			{
				return startview;
			}
		}

		public static RoutedUICommand Options
		{
			get
			{
				return options;
			}
		}

		public static RoutedUICommand About
		{
			get
			{
				return about;
			}
		}

		public static RoutedUICommand SaveAs
		{
			get
			{
				return saveas;
			}

		}

		public static RoutedUICommand Quit
		{
			get
			{
				return quit;
			}
		}

		public static RoutedUICommand ZoomIn
		{
			get
			{
				return zoomin;
			}
		}

		public static RoutedUICommand ZoomOut
		{
			get
			{
				return zoomout;
			}
		}

		public static RoutedUICommand Draw
		{
			get
			{
				return draw;
			}
		}

		public static RoutedUICommand Line
		{
			get
			{
				return line;
			}
		}

		public static RoutedUICommand Erase
		{
			get
			{
				return erase;
			}
		}
		public static RoutedUICommand Clear
		{
			get
			{
				return clear;
			}
		}
	}
}
