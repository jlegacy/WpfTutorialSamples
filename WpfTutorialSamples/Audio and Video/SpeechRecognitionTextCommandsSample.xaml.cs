using System;
using System.Speech.Recognition;
using System.Windows;

namespace WpfTutorialSamples.Audio_and_Video
{
	public partial class SpeechRecognitionTextCommandsSample : Window
	{
		public SpeechRecognitionTextCommandsSample()
		{
			InitializeComponent();
			SpeechRecognizer recognizer = new SpeechRecognizer();
		}

		private void btnNew_Click(object sender, RoutedEventArgs e)
		{
			txtSpeech.Text = "";
		}

		private void btnOpen_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Command invoked: Open");
		}

		private void btnSave_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Command invoked: Save");
		}
	}
}
