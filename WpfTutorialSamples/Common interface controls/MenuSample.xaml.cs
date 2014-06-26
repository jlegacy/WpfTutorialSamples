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

namespace WpfTutorialSamples.Common_interface_controls
{
	/// <summary>
	/// Interaction logic for MenuSample.xaml
	/// </summary>
	public partial class MenuSample : Window
	{
		public MenuSample()
		{
			InitializeComponent();
		}

private void mnuNew_Click(object sender, RoutedEventArgs e)
{
	MessageBox.Show("Test");
}
	}
}
