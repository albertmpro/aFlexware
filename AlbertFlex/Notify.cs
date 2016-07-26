using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
namespace Albert.Flex
{
	/// <summary>
	/// Base Class for working with models MVVM
	/// </summary>
    public abstract class Notify: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        // Method Changes the property
        protected void OnPropertyChanged(string Name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(Name));
            }
        }

    }
}
