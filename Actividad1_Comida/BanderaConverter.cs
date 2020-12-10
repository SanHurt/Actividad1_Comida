using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Actividad1_Comida
{
    class BanderaConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((string)value == "Mexicana")
                return "Assets/mexico.png";
            else if ((string)value == "Americana")
                return "Assets/united_states.png";
            else if ((string)value == "China")
                return "Assets/china.png";
            else
                return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
