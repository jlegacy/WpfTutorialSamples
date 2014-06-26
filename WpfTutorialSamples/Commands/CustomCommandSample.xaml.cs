using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

namespace WpfTutorialSamples.Commands
{
	public partial class CustomCommandSample : Window
	{
		public CustomCommandSample()
		{
			InitializeComponent();			
		}

		private void ExitCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
		{
			e.CanExecute = true;
		}

		private void ExitCommand_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			Application.Current.Shutdown();
		}
	}

	public static class CustomCommands
	{
		public static readonly RoutedUICommand Exit = new RoutedUICommand
			(
				"Exit",
				"Exit", 
				typeof(CustomCommands),
				new InputGestureCollection() 
				{ 
					new KeyGesture(Key.F4, ModifierKeys.Alt) 
				}
			);

		//Define more commands here, just like the one above
	}
}
