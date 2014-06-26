using System;
using System.Globalization;
using System.Threading;
using System.Windows;

namespace WpfTutorialSamples
{
	public partial class App : Application
	{
		private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
		{
			MessageBox.Show("An unhandled exception just occurred: " + e.Exception.Message, "Exception Sample", MessageBoxButton.OK, MessageBoxImage.Error);
			e.Handled = true;
		}

		private void Application_Startup(object sender, StartupEventArgs e)
		{
			this.SystemDefaultCulture = Thread.CurrentThread.CurrentCulture;
			Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
		}

		public CultureInfo SystemDefaultCulture { get; set; }
	}
}
