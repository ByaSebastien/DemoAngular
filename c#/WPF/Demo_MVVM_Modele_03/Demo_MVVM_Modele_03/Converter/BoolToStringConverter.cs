using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.MVVM.Converters;

namespace Demo_MVVM_Modele_03.Converter
{
    public class BoolToStringConverter : ConverterBase<bool, string>
    {
        public override string Convert(bool value, Type targetType, object parameter, CultureInfo culture)
        {
            return value ? "true" : "false";
        }

        public override bool ConvertBack(string value, Type targetType, object parameter, CultureInfo culture)
        {
            return value.ToLower() == "oui";
        }
    }
}
