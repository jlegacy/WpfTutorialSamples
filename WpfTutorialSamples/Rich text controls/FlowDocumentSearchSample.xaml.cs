using System;
using System.Windows;

namespace WpfTutorialSamples.Rich_text_controls
{
	public partial class FlowDocumentSearchSample : Window
	{
		public FlowDocumentSearchSample()
		{
			InitializeComponent();
		}

		private void btnSearch_Click(object sender, RoutedEventArgs e)
		{
			fdViewer.Find();
		}
	}
}
