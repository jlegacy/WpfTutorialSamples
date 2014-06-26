using System;
using System.Windows;
using System.Windows.Data;
using System.Diagnostics;

namespace WpfTutorialSamples.DataBinding
{
	public partial class DataBindingDebuggingSample : Window
	{
		public DataBindingDebuggingSample()
		{
			InitializeComponent();
		}
	}

	public class DebugDummyConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			Debugger.Break();
			return value;
		}

		public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			Debugger.Break();
			return value;
		}
	}
}
