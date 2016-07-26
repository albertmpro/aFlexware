using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

// The Templated Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234235

namespace Albert.Flex.Runtime
{
	/// <summary>
	/// Special ContentControl designed to be more flexible than a UserControl, and to display views 
	/// </summary>
	public  class VControl : ContentControl
	{
		

		public VControl()
		{
			this.DefaultStyleKey = typeof(VControl);
		}

		public event Action OnOkCommand;
		public event Action OnCancelCommand; 
		public event Action OnShowCommand;
		public void Show()
		{
			if (OnShowCommand != null)
				OnShowCommand();


			Visibility = Visibility.Visible;
		}

		public void Ok()
		{
			if (OnOkCommand != null)
				OnOkCommand();



			Visibility = Visibility.Collapsed;
		}
		public void Cancel()
		{
			if (OnCancelCommand != null)
				OnCancelCommand();


			Visibility = Visibility.Collapsed;
		}


	

		#region MessageBox

		public async Task MsgBox(string _message, string _title, string _option1)
		{
			var msg = new MessageDialog(_message, _title);
			msg.Commands.Clear();
			msg.Commands.Add(new UICommand { Label = _option1 });

			var rv = await msg.ShowAsync();



		}

		public async Task<int> MsgBox(string _message, string _title, string _option1, string _option2, Action<int> _method)
		{
			var msg = new MessageDialog(_message, _title);

			msg.Commands.Clear();
			msg.Commands.Add(new UICommand { Label = _option1, Id = 0 });
			msg.Commands.Add(new UICommand { Label = _option2, Id = 1 });
			// await the ShowAsync 
			var rv = await msg.ShowAsync();

			//Execute the method 
			_method((int)rv.Id);

			return (int)rv.Id;



		}

		#endregion


	}
}
