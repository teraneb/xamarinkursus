using Xamarin.Forms;
using System;
using System.Globalization;

namespace ValueConverters
{
    public class DateValueConverter : IValueConverter
    {
        

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            DateTime outputDate = (DateTime)value;
            return outputDate.DayOfWeek;
        }





        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
