using System;
using System.Windows;

namespace WpfTutorialSamples.Misc_controls
{
	public partial class CalendarSelectedDateSample : Window
	{
		public CalendarSelectedDateSample()
		{
			InitializeComponent();
			cldSample.SelectedDate = DateTime.Now.AddDays(1);
		}
	}
}
