using System;
using System.Collections.Generic;
using System.Text;
using Albert.Flex.Runtime;
using Windows.UI.Xaml.Controls;
namespace aFlexRuntime
{
	public abstract class FlexViewModel : ViewModel
	{

		/// <summary>
		/// Get or sets the Tombstone Image for the Sketch
		/// </summary>
		public Image StoredSketch { get; set; }
		/// <summary>
		/// Get or sets the Tombstone Image for a StoryBoard
		/// </summary>
		public Image StoryBoardSketch { get; set; }


		/// Get the Color list for an application 
		/// </summary>
		public RuntimeVMList<ColorModel> Colors { get; } = new RuntimeVMList<ColorModel>("aFlexIdea", "colors");
		/// <summary>
		/// Get the Web url's for an application 
		/// </summary>


		/// <summary>
		/// Gets or sets the menu button at the top 
		/// </summary>
		public HamburgerButton Menu { get; set; }

		/// <summary>
		/// Gets or sets the Default Frame for the Application
		/// </summary>
		public Frame Frame { get; set; }


		/// <summary>
		/// Get or sets the default SplitView 
		/// </summary>
		public SplitView SplitView { get; set; }

		/// <summary>
		/// Gets the Image Filter
		/// </summary>
		public List<string> ImgFilter { get; } = new List<string> { ".png", ".jpg" };


	}




}
