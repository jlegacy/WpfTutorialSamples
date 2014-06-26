using System;
using System.Windows;
using System.Windows.Data;

namespace WpfTutorialSamples.DataBinding
{
	public partial class MultiValueConverterSample : Window
	{
		public MultiValueConverterSample()
		{
			InitializeComponent();
		}
	}

	public class NameOrderConverter : IMultiValueConverter
	{
		public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			if((values != null) && (values.Length == 2))
			{
				if(culture.TwoLetterISOLanguageName == "de")
					return values[1] + ", " + values[0];
				else
					return values[0] + " " + values[1];
			}
			return String.Empty;
		}

		public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
		{
			string[] splitValues = ((string)value).Split(' ');
			return splitValues;
		}
	}
}
