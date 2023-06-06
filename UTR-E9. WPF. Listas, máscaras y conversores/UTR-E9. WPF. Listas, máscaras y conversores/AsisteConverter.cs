using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace UTR_E9.WPF.Listas__máscaras_y_conversores
{
    public class AsisteConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is bool asiste)
            {
                return asiste ? "Presente" : "No";
            }
            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool)
            {
                if ((bool)value == true)
                {
                    return "si";
                }
                else
                {
                    return "no";
                }
            }
            return "no";
        }
    }
}
