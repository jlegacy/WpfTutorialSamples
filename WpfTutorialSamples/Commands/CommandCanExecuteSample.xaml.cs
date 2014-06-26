using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

namespace WpfTutorialSamples.Commands
{
	public partial class CommandCanExecuteSample : Window
	{
		public CommandCanExecuteSample()
		{
			InitializeComponent();
		}

		private void CutCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
		{
			e.CanExecute = (txtEditor != null) && (txtEditor.SelectionLength > 0);			
		}

		private void CutCommand_Executed(object sender, ExecutedRoutedEventArgs e)
		{			
			txtEditor.Cut();
		}

		private void PasteCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
		{
			e.CanExecute = Clipboard.ContainsText();
		}

		private void PasteCommand_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			txtEditor.Paste();
		}
	}
}
