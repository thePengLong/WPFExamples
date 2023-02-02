using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace RadioBindingExample
{
    internal class RadioToBoolConveter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value != null && (value.ToString()?.Equals(parameter) ?? false);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value != null && value.Equals(true) ? parameter : Binding.DoNothing;
        }
    }

    public class EnumToBoolConveter<T> : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var val = (T)value;
            return val?.ToString() == parameter.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool isChecked = (bool)value;

            if (!isChecked)
            {
                return Binding.DoNothing;
            }
            else
            {
                return Enum.Parse(typeof(T), parameter.ToString());
            }
        }
    }

    public class SexToBoolConveter: EnumToBoolConveter<Sex>
    {

    }
}
