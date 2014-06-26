using System;
using System.IO;
using System.Windows;
using Microsoft.Win32;

namespace WpfTutorialSamples.Dialogs
{
	public partial class OpenFileDialogSample : Window
	{
		public OpenFileDialogSample()
		{
			InitializeComponent();
		}

		private void btnOpenFile_Click(object sender, RoutedEventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();			
			openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
			openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			if(openFileDialog.ShowDialog() == true)
				txtEditor.Text = File.ReadAllText(openFileDialog.FileName);
		}
	}
}
