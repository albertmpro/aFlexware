using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Albert.Flex.Windows;
using System.Windows.Controls;
using aFlexCode.View;
using System.Windows.Input;
namespace aFlexCode
{
	public class CodeViewModel : ViewModel
	{



		/// <summary>
		/// Default Constructor 
		/// </summary>
		public CodeViewModel()
		{
			
		}

		/// <summary>
		/// Gets or sets the Tab that will be used Application 
		/// </summary>
		public TabControl Tab { get; set; }


		/// <summary>
		/// Gets or sets the title 
		/// </summary>
		public string Title { get; set; } = "aFlexCode";

		/// <summary>
		/// Gets or sets the Current Mode 
		/// </summary>
		public FlexCodeMode Mode { get; set; } = FlexCodeMode.TextEditor;



		#region Filter's 
		/// <summary>
		/// Gets the default filter for hte TextEditor 
		/// </summary>
		public string TextFilter { get; } = "All Formats(.)|*.*";

		public string WptFilter { get; } = "WordPress Theme File(.wpt)|*.wpt";

		public string WppFilter { get; } = "WordPress Plugin File(.wpp)|*.wpp";

		public string StyleFilter { get; } = "Stylesheet Theme File(.styt)|*.styt";

		public string WebStartFilter { get; } = "Web Starter FIle(.webst)|*.webst"; 
		#endregion



	}

	public enum FlexCodeMode
	{
		TextEditor,
		WebStarter,
		WordPressTheme,
		WordPressPlugin,
		Stylesheet 
	}

}