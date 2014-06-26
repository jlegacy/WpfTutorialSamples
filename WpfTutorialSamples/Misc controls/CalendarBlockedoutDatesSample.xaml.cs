using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfTutorialSamples.Misc_controls
{
	public partial class CalendarBlockedoutDatesSample : Window
	{
		public CalendarBlockedoutDatesSample()
		{
			InitializeComponent();
			cldSample.BlackoutDates.AddDatesInPast();
			cldSample.BlackoutDates.Add(new CalendarDateRange(DateTime.Today, DateTime.Today.AddDays(1)));
		}
	}
}
