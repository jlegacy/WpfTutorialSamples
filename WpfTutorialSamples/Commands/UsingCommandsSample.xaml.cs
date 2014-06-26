using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

namespace WpfTutorialSamples.Commands
{
	public partial class UsingCommandsSample : Window
	{
		public UsingCommandsSample()
		{
			InitializeComponent();
		}

		private void NewCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
		{
			e.CanExecute = true;
		}

		private void NewCommand_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			MessageBox.Show("The New command was invoked");
		}
	}
}
