using System.Globalization;
using System.Windows.Data;
using System;

namespace MVVMDemo
{
    public class DatetimeToDateConverter : IValueConverter  
    {  
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)  
        {  
            DateTime date = (DateTime)value;  
            return date.ToString("MM/d/yyyy");  
        }  
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)  
        {  
            return value;  
        }  
    }  
}