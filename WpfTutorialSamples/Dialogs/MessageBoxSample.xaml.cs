using System;
using System.Windows;

namespace WpfTutorialSamples.Dialogs
{
	public partial class MessageBoxSample : Window
	{
		public MessageBoxSample()
		{
			InitializeComponent();
		}

		private void btnSimpleMessageBox_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Hello, world!");
		}

		private void btnMessageBoxWithTitle_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Hello, world!", "My App");
		}

		private void btnMessageBoxWithButtons_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("This MessageBox has extra options.\n\nHello, world?", "My App", MessageBoxButton.YesNoCancel);
		}

		private void btnMessageBoxWithResponse_Click(object sender, RoutedEventArgs e)
		{
			MessageBoxResult result = MessageBox.Show("Would you like to greet the world with a \"Hello, world\"?", "My App", MessageBoxButton.YesNoCancel);
			switch(result)
			{
				case MessageBoxResult.Yes:
					MessageBox.Show("Hello to you too!", "My App");
					break;
				case MessageBoxResult.No:
					MessageBox.Show("Oh well, too bad!", "My App");
					break;
				case MessageBoxResult.Cancel:
					MessageBox.Show("Nevermind then...", "My App");
					break;
			}
		}

		private void btnMessageBoxWithIcon_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Hello, world!", "My App", MessageBoxButton.OK, MessageBoxImage.Information);
		}

		private void btnMessageBoxWithDefaultChoice_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Hello, world?", "My App", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
		}
	}
}
