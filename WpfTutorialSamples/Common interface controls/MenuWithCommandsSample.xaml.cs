using System;
using System.Windows;
using System.Windows.Input;

namespace WpfTutorialSamples.Common_interface_controls
{
	public partial class MenuWithCommandsSample : Window
	{
		public MenuWithCommandsSample()
		{
			InitializeComponent();
		}

		private void NewCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
		{
			e.CanExecute = true;
		}

		private void NewCommand_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			txtEditor.Text = "";
		}
	}
}
