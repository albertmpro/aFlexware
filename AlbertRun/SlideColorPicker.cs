using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;

// The Templated Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234235

namespace Albert.Flex.Runtime
{
	[TemplatePart(Name = "PART_SlideRed", Type = typeof(Slider))]
	[TemplatePart(Name = "PART_SlideGreen", Type = typeof(Slider))]
	[TemplatePart(Name = "PART_SlideBlue", Type = typeof(Slider))]
	[TemplatePart(Name = "PART_RectangleColor", Type = typeof(Rectangle))]
	/// <summary>
	/// Pick a color with sliders 
	/// </summary>
	public sealed class SlideColorPicker : Control
	{


		Slider slideRed = new Slider();
		Slider slideGreen = new Slider();
		Slider slideBlue = new Slider();
		Rectangle rectangle = new Rectangle();
		public SlideColorPicker()
		{
			this.DefaultStyleKey = typeof(SlideColorPicker);
		}

		protected override void OnApplyTemplate()
		{
			base.OnApplyTemplate();

			slideRed = GetTemplateChild("PART_SlideRed") as Slider;
			slideGreen = GetTemplateChild("PART_SlideGreen") as Slider;
			slideBlue = GetTemplateChild("PART_SlideBlue") as Slider;
			rectangle = GetTemplateChild("PART_RectangleColor") as Rectangle;
			//Changed 
			slideRed.ValueChanged += Slide_ValueChanged;
			slideGreen.ValueChanged += Slide_ValueChanged;
			slideBlue.ValueChanged += Slide_ValueChanged;
		}
		public event Action<Color> OnColorChanged;


		public static readonly DependencyProperty ColorProperty = DependencyProperty.Register("Color",
			typeof(Color),
			typeof(ColorPickBase), new PropertyMetadata(Colors.Black, ((sender, e) =>
			{
				SlideColorPicker slide = (SlideColorPicker)sender;
				var color = slide.Color; 

				if(color != null)
				{
					slide.slideRed.Value = color.R;
					slide.slideGreen.Value = color.G;
					slide.slideBlue.Value = color.B;
				}

			})));

		public Color Color
		{
			get { return (Color)GetValue(ColorProperty); }
			set { SetValue(ColorProperty, value); }
		}


		void Slide_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
		{
			//Convert Slide values to Color Values 
			byte R, G, B;
			R = Convert.ToByte(slideRed.Value);
			G = Convert.ToByte(slideGreen.Value);
			B = Convert.ToByte(slideBlue.Value);
			Color = Color.FromArgb(255, R, G, B);
			rectangle.Fill = new SolidColorBrush(Color);

			if (OnColorChanged != null)
			{
				OnColorChanged(Color);
			}
		}


	}
}
