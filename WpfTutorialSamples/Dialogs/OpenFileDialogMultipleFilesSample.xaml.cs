using System;
using System.IO;
using System.Windows;
using Microsoft.Win32;

namespace WpfTutorialSamples.Dialogs
{
	public partial class OpenFileDialogMultipleFilesSample : Window
	{
		public OpenFileDialogMultipleFilesSample()
		{
			InitializeComponent();
		}

		private void btnOpenFiles_Click(object sender, RoutedEventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Multiselect = true;
			openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
			openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Windows);
			if(openFileDialog.ShowDialog() == true)
			{
				foreach(string filename in openFileDialog.FileNames)
					lbFiles.Items.Add(filename);
			}
		}
	}
}
