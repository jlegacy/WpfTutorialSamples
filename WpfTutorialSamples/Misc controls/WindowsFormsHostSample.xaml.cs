using System;
using System.Windows;

namespace WpfTutorialSamples.Misc_controls
{
	public partial class WindowsFormsHostSample : Window
	{
		public WindowsFormsHostSample()
		{			
			InitializeComponent();
			(wfhSample.Child as System.Windows.Forms.WebBrowser).Navigate("http://www.wpf-tutorial.com");
		}

		private void wbWinForms_DocumentTitleChanged(object sender, EventArgs e)
		{
			this.Title = (sender as System.Windows.Forms.WebBrowser).DocumentTitle;
		}
	}
}
