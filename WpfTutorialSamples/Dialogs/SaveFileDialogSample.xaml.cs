using System;
using System.IO;
using System.Windows;
using Microsoft.Win32;

namespace WpfTutorialSamples.Dialogs
{
	public partial class SaveFileDialogSample : Window
	{
		public SaveFileDialogSample()
		{
			InitializeComponent();
		}

		private void btnSaveFile_Click(object sender, RoutedEventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "Text file (*.txt)|*.txt|C# file (*.cs)|*.cs";
			saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			if(saveFileDialog.ShowDialog() == true)
				File.WriteAllText(saveFileDialog.FileName, txtEditor.Text);
		}
	}
}
