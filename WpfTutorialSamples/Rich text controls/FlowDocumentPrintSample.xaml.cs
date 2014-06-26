using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfTutorialSamples.Rich_text_controls
{
	public partial class FlowDocumentPrintSample : Window
	{
		public FlowDocumentPrintSample()
		{
			InitializeComponent();
		}

		private void btnPrint_Click(object sender, RoutedEventArgs e)
		{
			fdViewer.Print();
		}

		private void btnPrintPreview_Click(object sender, RoutedEventArgs e)
		{
			Window previewWindow = new Window();
			previewWindow.Title = "Print preview";
			DocumentViewer docViewer = new DocumentViewer();
			docViewer.Document = fdViewer.Document;
			previewWindow.Content = docViewer;
			previewWindow.ShowDialog();
		}
	}
}
