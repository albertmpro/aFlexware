using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace Albert.Flex.Runtime
{
	
	/// <summary>
	/// A special button for the SplitView
	/// </summary>
	public class HamburgerButton: PushButton
	{
		public static readonly DependencyProperty SymbolProperty = DependencyProperty.Register(
			"Symbol", typeof(string), typeof(HamburgerButton), null);


		public static readonly DependencyProperty LabelProperty = DependencyProperty.Register(
			"Label", typeof(string), typeof(HamburgerButton), null);



		public static readonly DependencyProperty SymbolFontFamilyProperty = DependencyProperty.Register("SymbolFontFamily", typeof(FontFamily), typeof(HamburgerButton), new PropertyMetadata(new FontFamily("Segoe MDL2 Assets")));



		public HamburgerButton()
		{
			DefaultStyleKey = typeof(HamburgerButton);
		}

		public string Symbol
		{
			get
			{
				return (string)GetValue(SymbolProperty);
			}
			set
			{
				SetValue(SymbolProperty, value);
			}
		}
		public string Label
		{
			get
			{
				return (string)GetValue(LabelProperty);
			}
			set
			{
				SetValue(LabelProperty, value);
			}
		}

		public FontFamily SymbolFontFamily
		{
			get
			{
				return (FontFamily)GetValue(SymbolFontFamilyProperty);
			}
			set
			{
				SetValue(SymbolFontFamilyProperty, value);
			}
		}

	}
}
