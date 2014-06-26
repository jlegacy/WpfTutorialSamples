using System;
using System.Windows;

namespace WpfTutorialSamples.Common_interface_controls
{
	public partial class StatusBarAdvancedSample : Window
	{
		public StatusBarAdvancedSample()
		{
			InitializeComponent();
		}

		private void txtEditor_SelectionChanged(object sender, RoutedEventArgs e)
		{
			int row = txtEditor.GetLineIndexFromCharacterIndex(txtEditor.CaretIndex);
			int col = txtEditor.CaretIndex - txtEditor.GetCharacterIndexFromLineIndex(row);
			lblCursorPosition.Text = "Line " + (row + 1) + ", Char " + (col + 1);
		}
	}
}
