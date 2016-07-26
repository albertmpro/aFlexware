using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Albert.Flex.Runtime.AsyncIO;
using Windows.Storage;
namespace Albert.Flex.Runtime
{
	/// <summary>
	/// Base Class for doing ViewModel's with Windows App's or Windows Phone App's
	/// </summary>
	public abstract class ViewModel : Notify, IViewModel
	{


		public ApplicationDataContainer Settings { get; } = ApplicationData.Current.LocalSettings;

		public StorageFolder LocalFolder  { get; } = ApplicationData.Current.LocalFolder;


		/// <summary>
		/// Sends a event for Notification
		/// </summary>
		public event Action<string> OnNotification;





		/// <summary>
		/// Sends a message to another page 
		/// </summary>

		public void Notify(string _value)
		{
			if (OnNotification != null)
			{
				OnNotification(_value);
			}
		}


		public object Message { get; set; }
	}
}
