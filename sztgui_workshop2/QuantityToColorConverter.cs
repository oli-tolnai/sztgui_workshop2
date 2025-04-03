using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace sztgui_workshop2
{
    public class QuantityToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is int strength)
            {
                if (strength <= 100 && strength > 70)
                    return Brushes.Green;
                else if (strength <= 70 && strength > 34)
                    return Brushes.Yellow;
                else if (strength < 34)
                    return Brushes.Red;
                else
                    return Brushes.Red;
            }
            if (value is int speed)
            {
                if (speed <= 100 && speed > 70)
                    return Brushes.Green;
                else if (speed <= 70 && speed > 34)
                    return Brushes.Yellow;
                else if (speed < 34)
                    return Brushes.Red;
                else
                    return Brushes.Red;
            }

            return Brushes.Gray;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
