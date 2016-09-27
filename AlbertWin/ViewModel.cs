using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Albert.Flex.Windows
{
    public abstract class ViewModel: Notify, IViewModel
    {


        /// <summary>
        /// Method allows the ViewModel to run other .exe on the system 
        /// </summary>
        /// <param name="exeFile">File path of the .exe file</param>
        public void RunExeFile(string exeFile)
        {
            Process p = new Process();
            p.StartInfo.FileName = exeFile;
            p.Start();
        }

		public void Notify(string _value)
		{
			if (OnNotification != null)
			{
				//Run the Notification event here 
				OnNotification(_value);
			}
		}
        //Interface values 

        /// <summary>
        /// Event for Notifying the application of something 
        /// </summary>
        public event Action<string> OnNotification;

        /// <summary>
        /// Gets or sets a Message to be sent across the Application 
        /// </summary>
        public object Message
        {
            get;
            set;
        }
    }
}
