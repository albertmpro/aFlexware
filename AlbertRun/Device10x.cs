using System;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.ViewManagement;
namespace Albert.Flex.Runtime
{
	/// <summary>
	/// Class for dealing with device specific features 
	/// </summary>
	public static class Device10x
	{


		/// <summary>
		/// 
		/// </summary>
		/// <param name="_ttile"></param>
		/// <param name="_message"></param>
		/// <param name="_btn1"></param>
		/// <param name="_btn2"></param>
		/// <param name="_method"></param>
		/// <returns></returns>
		public static async Task<MsgDialog> MsgShow(string _title,object _message,string _btn1, string _btn2, Action _method)
		{
			var msg = new MsgDialog(_title, _message, _btn1, _btn2, _method);

			await msg.ShowAsync();

			return msg;
		}


		public static async Task<MsgDialog> MsgShow(string _title, object _message, string _btn1, string _btn2, Action _method, Action _method2)
		{
			var msg = new MsgDialog(_title, _message, _btn1, _btn2, _method, _method2);

			await msg.ShowAsync();

			return msg;
		}

		public static async Task<MsgDialog> MsgShow(string _title, object _message, string _btn1)
		{
			var msg = new MsgDialog(_title, _message, _btn1);

			await msg.ShowAsync();

			return msg;
		}




		public static void SetTitle(string _title)
		{
			var AppView = ApplicationView.GetForCurrentView();
			AppView.Title = _title;
		}
		/// <summary>
		/// Set the TitleBar Chrome for a Desktop or Touch Application 
		/// </summary>
		/// <param name="_background">Define Background</param>
		/// <param name="_foreground">Define Foreground</param>
		public static void TitleBarStyle(Color _background , Color _foreground)
		{

			var AppView = ApplicationView.GetForCurrentView();
			AppView.TitleBar.BackgroundColor = _background;
			AppView.TitleBar.ForegroundColor = _foreground;
			
			AppView.TitleBar.ButtonBackgroundColor = _background;
			AppView.TitleBar.ButtonForegroundColor = _foreground;
			AppView.TitleBar.InactiveBackgroundColor = _background;
			AppView.TitleBar.ButtonInactiveBackgroundColor = _background;



		}
		/// <summary>
		/// Set the TitleBar Chrome and Button Colors for a Desktop or Touch Application 
		/// </summary>
		/// <param name="_background">Define the Background Color</param>
		/// <param name="_foreground">Defnine the Foreground Color</param>
		/// <param name="_btnbackground">Define Button Background</param>
		/// <param name="_btnforeground">Define Button Foreground</param>
		public static void TitleBarStyle(Color _background, Color _foreground,Color _btnbackground, Color _btnforeground)
		{

			var AppView = ApplicationView.GetForCurrentView();
			AppView.TitleBar.BackgroundColor = _background;
			AppView.TitleBar.ForegroundColor = _foreground;
			AppView.TitleBar.ButtonBackgroundColor = _btnbackground;
			AppView.TitleBar.ButtonForegroundColor = _btnforeground;
			AppView.TitleBar.InactiveBackgroundColor = _background;
			AppView.TitleBar.ButtonInactiveBackgroundColor = _background;
			



		}
		/// <summary>
		/// Does a Task that only works on the Phone
		/// </summary>
		/// <param name="method"></param>
		public static void PhoneTask(Action method)
		{
			if (Windows.Foundation.Metadata.ApiInformation.IsTypePresent("Windows.Phone.UI.Input.HardwareButtons"))
			{
				if (method != null)
					method();//Execute Method 
			}
		}

	}
}
