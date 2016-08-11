using System;
using System.Collections.Generic;
using System.Text;
using Albert.Flex;
using Windows.UI;
namespace aFlexRuntime
{
	/// <summary>
	/// Model for Captureing a 7 color theme set 
	/// </summary>
    public class SevenColorModel: Notify
    {
		//Field's 
		Color c1, c2, c3, c4, c5, c6, c7; 

		/// <summary>
		/// Gets or set the First Color
		/// </summary>
		public Color Color1
		{
			get { return c1; }
			set { c1 = value; OnPropertyChanged("Color1"); }
		}
		/// <summary>
		/// Gets or set the Second Color
		/// </summary>
		public Color Color2
		{
			get { return c2; }
			set { c2 = value; OnPropertyChanged("Color2"); }
		}
		/// <summary>
		/// Gets or set the First Color
		/// </summary>
		public Color Color3
		{
			get { return c3; }
			set { c3 = value; OnPropertyChanged("Color3"); }
		}
		/// <summary>
		/// Gets or set the Fourth Color
		/// </summary>
		public Color Color4
		{
			get { return c4; }
			set { c4 = value; OnPropertyChanged("Color4"); }
		}
		/// <summary>
		/// Gets or set the Fith Color
		/// </summary>
		public Color Color5
		{
			get { return c5; }
			set { c5 = value; OnPropertyChanged("Color5"); }
		}
		/// <summary>
		/// Gets or set the Sixth Color
		/// </summary>
		public Color Color6
		{
			get { return c6; }
			set { c6 = value; OnPropertyChanged("Color6"); }
		}
		/// <summary>
		/// Gets or set the Seventh Color
		/// </summary>
		public Color Color7
		{
			get { return c7; }
			set { c7 = value; OnPropertyChanged("Color7"); }
		}



	}
}
