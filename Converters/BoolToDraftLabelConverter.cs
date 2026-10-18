using System.Globalization;

namespace Sukali.Converters;

public class BoolToDraftLabelConverter : IValueConverter
{
    public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is bool isDraft)
            return isDraft ? "Brouillon" : "Publié";
        return string.Empty;
    }

    public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
