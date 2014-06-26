using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace WpfTutorialSamples.Rich_text_controls
{
	public partial class RichTextBoxTextSelectionSample : Window
	{
		public RichTextBoxTextSelectionSample()
		{
			InitializeComponent();
		}

		private void btnGetText_Click(object sender, RoutedEventArgs e)
		{
			TextRange textRange = new TextRange(rtbEditor.Document.ContentStart, rtbEditor.Document.ContentEnd);
			MessageBox.Show(textRange.Text);
		}

		private void btnSetText_Click(object sender, RoutedEventArgs e)
		{
			TextRange textRange = new TextRange(rtbEditor.Document.ContentStart, rtbEditor.Document.ContentEnd);
			textRange.Text = "Another world, another text!";
		}

		private void btnGetSelectedText_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show(rtbEditor.Selection.Text);
		}

		private void btnSetSelectedText_Click(object sender, RoutedEventArgs e)
		{
			rtbEditor.Selection.Text = "[Replaced text]";
		}

		private void rtbEditor_SelectionChanged(object sender, RoutedEventArgs e)
		{
			TextRange tempRange = new TextRange(rtbEditor.Document.ContentStart, rtbEditor.Selection.Start);			
			txtStatus.Text = "Selection starts at character #" + tempRange.Text.Length + Environment.NewLine;
			txtStatus.Text += "Selection is " + rtbEditor.Selection.Text.Length + " character(s) long" + Environment.NewLine;
			txtStatus.Text += "Selected text: '" + rtbEditor.Selection.Text + "'";
		}
	}
}
