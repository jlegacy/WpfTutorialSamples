using System;
using System.Windows;
using System.Windows.Input;

namespace WpfTutorialSamples.Misc_controls
{
	public partial class WebBrowserControlSample : Window
	{
		public WebBrowserControlSample()
		{
			InitializeComponent();
			wbSample.Navigate("http://www.wpf-tutorial.com");
		}

		private void txtUrl_KeyUp(object sender, KeyEventArgs e)
		{
			if(e.Key == Key.Enter)
				wbSample.Navigate(txtUrl.Text);
		}

		private void wbSample_Navigating(object sender, System.Windows.Navigation.NavigatingCancelEventArgs e)
		{
			txtUrl.Text = e.Uri.OriginalString;
		}

		private void BrowseBack_CanExecute(object sender, CanExecuteRoutedEventArgs e)
		{
			e.CanExecute = ((wbSample != null) && (wbSample.CanGoBack));
		}

		private void BrowseBack_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			wbSample.GoBack();
		}

		private void BrowseForward_CanExecute(object sender, CanExecuteRoutedEventArgs e)
		{
			e.CanExecute = ((wbSample != null) && (wbSample.CanGoForward));
		}

		private void BrowseForward_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			wbSample.GoForward();
		}		

		private void GoToPage_CanExecute(object sender, CanExecuteRoutedEventArgs e)
		{
			e.CanExecute = true;
		}

		private void GoToPage_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			wbSample.Navigate(txtUrl.Text);
		}

	}
}
