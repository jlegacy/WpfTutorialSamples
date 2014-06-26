using System;
using System.Windows;
using System.Windows.Media;
using Microsoft.Win32;

namespace WpfTutorialSamples.Audio_and_Video
{
	public partial class MediaPlayerAudioSample : Window
	{
		private MediaPlayer mediaPlayer = new MediaPlayer();

		public MediaPlayerAudioSample()
		{
			InitializeComponent();
		}

		private void btnOpenAudioFile_Click(object sender, RoutedEventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "MP3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
			if(openFileDialog.ShowDialog() == true)
			{
				mediaPlayer.Open(new Uri(openFileDialog.FileName));
				mediaPlayer.Play();
			}
		}
	}
}
