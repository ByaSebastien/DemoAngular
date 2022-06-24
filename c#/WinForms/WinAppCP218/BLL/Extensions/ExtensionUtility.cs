using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Extensions
{
    public static class ExtensionUtility
    {
        public static T ToEnum<T>(this string pValue, T pDefaultValue) where T : struct
        {
            if (string.IsNullOrWhiteSpace(pValue))
                return pDefaultValue;
            T result;
            return Enum.TryParse<T>(pValue,true, out result)? result : pDefaultValue;
        }
        public static bool isEven(this int pValue)
        {
            return pValue % 2 == 0;
        }
    }
}
