using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
namespace Albert.Flex.Runtime
{
	[TemplatePart(Name = "PART_LayoutRoot", Type = typeof(Grid))]
	[TemplatePart(Name = "PART_SplitView", Type = typeof(SplitView))]
	[TemplatePart(Name = "PART_StatusPanel", Type = typeof(StackPanel))]
	[TemplatePart(Name = "PART_Status", Type = typeof(TextBlock))]
	public class HamburgerView: Control
	{


	}
}
