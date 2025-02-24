using System.Globalization;
using System.Windows.Data;

namespace UI.Components
{
    public class PasswordToSecretConverter : IValueConverter
    {

        #region IValueConverter Members

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // The value parameter is the data from the source object.
            string password = (string)value;
            foreach (char c in password)
            {
                password = password.Replace(c, '*');
            }

            // Return the month value to pass to the target.
            return password;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (string)value;
        }

        #endregion
    }
}
