using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Albert.Flex
{
	public static class EnumUtility
	{
		public static T ConvertEnum<T>(string strvalue)
		{
			return (T)Enum.Parse(typeof(T), strvalue, true);
		}
	}
}
