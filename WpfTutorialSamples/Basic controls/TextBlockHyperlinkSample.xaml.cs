using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfTutorialSamples.Basic_controls
{
	/// <summary>
	/// Interaction logic for TextBlockHyperlinkSample.xaml
	/// </summary>
	public partial class TextBlockHyperlinkSample : Window
	{
		public TextBlockHyperlinkSample()
		{
			InitializeComponent();
		}

private void Hyperlink_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
{
	System.Diagnostics.Process.Start(e.Uri.AbsoluteUri);
}
	}
}
