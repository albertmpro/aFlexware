using System;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.ViewManagement;
using static Albert.Flex.Runtime.Device10x;
using Windows.Phone.UI.Input;
using Windows.Graphics.Display;
using Windows.UI.Popups;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml;
using Windows.UI;

namespace Albert.Flex.Runtime
{
	/// <summary>
	/// Dynamic Page that can be used for multiple divices 
	/// </summary>
	public class Page10x : Page
	{
		CommandBar commandBar;
		//ContentDialog msg;
		/// <summary>
		/// Hide the Phone StatusBar with this 
		/// </summary>
		public void HidePhoneStatusBar()
		{
			PhoneTask(async () =>
			{
				var statusbar = StatusBar.GetForCurrentView();
				await statusbar.HideAsync(); // Hide the statusbar
			});
		}

		/// <summary>
		/// Set the Orientation with this method  
		/// </summary>
		/// <param name="_Orientation"></param>
		public void Orientation(DisplayOrientations _Orientation)
		{

			DisplayInformation.AutoRotationPreferences = _Orientation;

		}

		protected virtual void OnNotify(string _msg)
		{

		}

		protected virtual void On_PhoneGoBack(object sender, BackPressedEventArgs e)
		{
			PhoneTask(() =>
			{
				e.Handled = true;
				Frame.GoBack();
			});


		}




		#region AppBar and Commands 
		/// <summary>
		/// Create's a CommandBar for the Phone Page 
		/// </summary>
		/// <param name="_background"></param>
		/// <param name="_foreground"></param>
		public void InitPhoneCommandBar(Color _background, Color _foreground)
		{

			PhoneTask(() =>
			{
				var back = new SolidColorBrush(_background);
				var fore = new SolidColorBrush(_foreground);

				//Create the commandbar 
				commandBar = new CommandBar { Background = back, Foreground = fore };
				BottomAppBar = commandBar;
			});


			PhoneTask(() =>
			{

			});


		}
		/// <summary>
		/// Executes all the commands with 1 click 
		/// </summary>
		public event Action<string> OnPhoneCommandBar;

		void command_Click(object sender, RoutedEventArgs e)
		{

			PhoneTask(() =>
			{
				var phone = sender as CmdButton;

				//Execute OnCommandBar 
				if (OnPhoneCommandBar != null)
				{
					OnPhoneCommandBar(phone.Label);
				}
			});

		}

		/// <summary>
		/// Clears all of the phone commands
		/// </summary>
		public void ClearAllPhoneCommands()
		{
			PhoneTask(() =>
			{
				commandBar.PrimaryCommands.Clear();
				commandBar.SecondaryCommands.Clear();
			});

		}
		/// <summary>
		/// Set's the Primary Commands for the Phone 
		/// </summary>
		/// <param name="_btn1"></param>
		public void SetPrimaryPhoneCommands(CmdButton _btn1)
		{

			PhoneTask(() =>
			{
				commandBar.PrimaryCommands.Clear();

				commandBar.PrimaryCommands.Add(_btn1);
				_btn1.Click += command_Click;
			});

		}
		/// <summary>
		/// Set's the Primary Commands for the Phone 
		/// </summary>
		public void SetPrimaryPhoneCommands(CmdButton _btn1, CmdButton _btn2)
		{
			PhoneTask(() =>
			{
				commandBar.PrimaryCommands.Clear();
				_btn1.Click += command_Click;
				_btn2.Click += command_Click;

				commandBar.PrimaryCommands.Add(_btn1);
				commandBar.PrimaryCommands.Add(_btn2);
			});

		}
		/// <summary>
		/// Set's the Primary Commands for the Phone 
		/// </summary>
		public void SetPrimaryPhoneCommands(CmdButton _btn1, CmdButton _btn2, CmdButton _btn3)
		{
			PhoneTask(() =>
			{
				commandBar.PrimaryCommands.Clear();
				_btn1.Click += command_Click;
				_btn2.Click += command_Click;
				_btn3.Click += command_Click;
				commandBar.PrimaryCommands.Add(_btn1);
				commandBar.PrimaryCommands.Add(_btn2);
				commandBar.PrimaryCommands.Add(_btn3);
			});


		}
		/// <summary>
		/// Set's the Primary Commands for the Phone 
		/// </summary>
		public void SetPrimaryPhoneCommands(CmdButton _btn1, CmdButton _btn2, CmdButton _btn3, CmdButton _btn4)
		{

			PhoneTask(() =>
			{
				commandBar.PrimaryCommands.Clear();
				_btn1.Click += command_Click;
				_btn2.Click += command_Click;
				_btn3.Click += command_Click;
				_btn4.Click += command_Click;

				commandBar.PrimaryCommands.Add(_btn1);
				commandBar.PrimaryCommands.Add(_btn2);
				commandBar.PrimaryCommands.Add(_btn3);
				commandBar.PrimaryCommands.Add(_btn4);
			});

		}
		/// <summary>
		/// Set's the Secondary Commands for the Phone 
		/// </summary>
		public void SetSecondaryPhoneCommands(CmdButton _btn1)
		{
			PhoneTask(() =>
			{
				commandBar.SecondaryCommands.Clear();
				_btn1.Click += command_Click;
				commandBar.SecondaryCommands.Add(_btn1);
			});


		}
		/// <summary>
		/// Set's the Secondary Commands for the Phone 
		/// </summary>
		public void SetSecondaryPhoneCommands(CmdButton _btn1, CmdButton _btn2)
		{

			PhoneTask(() =>
			{
				commandBar.SecondaryCommands.Clear();
				_btn1.Click += command_Click;
				_btn2.Click += command_Click;


				commandBar.SecondaryCommands.Add(_btn1);
				commandBar.SecondaryCommands.Add(_btn2);
			});

		}
		/// <summary>
		/// Set's the Secondary Commands for the Phone 
		/// </summary>
		public void SetSecondaryPhoneCommands(CmdButton _btn1, CmdButton _btn2, CmdButton _btn3)
		{

			PhoneTask(() =>
			{ 
				commandBar.SecondaryCommands.Clear();
				_btn1.Click += command_Click;
				_btn2.Click += command_Click;
				_btn3.Click += command_Click;


				commandBar.SecondaryCommands.Add(_btn1);
				commandBar.SecondaryCommands.Add(_btn2);
				commandBar.SecondaryCommands.Add(_btn3);
			});


		}

		/// <summary>
		/// Set's the Secondary Commands for the Phone 
		/// </summary>
		public void SetSecondaryPhoneCommands(CmdButton _btn1, CmdButton _btn2, CmdButton _btn3, CmdButton _btn4)
		{
			PhoneTask(() =>
			{
				commandBar.SecondaryCommands.Clear();
				_btn1.Click += command_Click;
				_btn2.Click += command_Click;
				_btn3.Click += command_Click;
				_btn4.Click += command_Click;


				commandBar.SecondaryCommands.Add(_btn1);
				commandBar.SecondaryCommands.Add(_btn2);
				commandBar.SecondaryCommands.Add(_btn3);
				commandBar.SecondaryCommands.Add(_btn4);
			});

		}
		/// <summary>
		/// Set's the Secondary Commands for the Phone 
		/// </summary>
		public void SetSecondaryPhoneCommands(CmdButton _btn1, CmdButton _btn2, CmdButton _btn3, CmdButton _btn4, CmdButton _btn5)
		{
			PhoneTask(() =>
			{
				commandBar.SecondaryCommands.Clear();
				_btn1.Click += command_Click;
				_btn2.Click += command_Click;
				_btn3.Click += command_Click;
				_btn4.Click += command_Click;
				_btn5.Click += command_Click;

				commandBar.SecondaryCommands.Add(_btn1);
				commandBar.SecondaryCommands.Add(_btn2);
				commandBar.SecondaryCommands.Add(_btn3);
				commandBar.SecondaryCommands.Add(_btn4);
				commandBar.SecondaryCommands.Add(_btn5);
			});

		}
		/// <summary>
		/// Set's the Secondary Commands for the Phone 
		/// </summary>
		public void SetSecondaryPhoneCommands(CmdButton _btn1, CmdButton _btn2, CmdButton _btn3, CmdButton _btn4, CmdButton _btn5, CmdButton _btn6)
		{
			PhoneTask(() =>
			{
				commandBar.SecondaryCommands.Clear();
				_btn1.Click += command_Click;
				_btn2.Click += command_Click;
				_btn3.Click += command_Click;
				_btn4.Click += command_Click;
				_btn5.Click += command_Click;
				_btn6.Click += command_Click;

				commandBar.SecondaryCommands.Add(_btn1);
				commandBar.SecondaryCommands.Add(_btn2);
				commandBar.SecondaryCommands.Add(_btn3);
				commandBar.SecondaryCommands.Add(_btn4);
				commandBar.SecondaryCommands.Add(_btn5);
				commandBar.SecondaryCommands.Add(_btn6);

			});

		}
		/// <summary>
		/// Set's the Secondary Commands for the Phone 
		/// </summary>
		public void SetSecondaryPhoneCommands(CmdButton _btn1, CmdButton _btn2, CmdButton _btn3, CmdButton _btn4, CmdButton _btn5, CmdButton _btn6, CmdButton _btn7)
		{
			PhoneTask(() =>
			{
				commandBar.SecondaryCommands.Clear();
				_btn1.Click += command_Click;
				_btn2.Click += command_Click;
				_btn3.Click += command_Click;
				_btn4.Click += command_Click;
				_btn5.Click += command_Click;
				_btn6.Click += command_Click;
				_btn7.Click += command_Click;

				commandBar.SecondaryCommands.Add(_btn1);
				commandBar.SecondaryCommands.Add(_btn2);
				commandBar.SecondaryCommands.Add(_btn3);
				commandBar.SecondaryCommands.Add(_btn4);
				commandBar.SecondaryCommands.Add(_btn5);
				commandBar.SecondaryCommands.Add(_btn6);
				commandBar.SecondaryCommands.Add(_btn7);
			});


		}
		#endregion



	}
}
