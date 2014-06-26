using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfTutorialSamples.Common_interface_controls
{
	public partial class ContextMenuManuallyInvokedSample : Window
	{
		public ContextMenuManuallyInvokedSample()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			ContextMenu cm = this.FindResource("cmButton") as ContextMenu;
			cm.PlacementTarget = sender as Button;
			cm.IsOpen = true;
		}
	}
}
