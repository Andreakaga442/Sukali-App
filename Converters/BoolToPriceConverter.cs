using System.Globalization;

namespace Sukali.Converters;

public class BoolToPriceConverter : IValueConverter
{
    public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is bool isFree)
            return isFree ? "Gratuit" : "Payant";
        return string.Empty;
    }

    public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
