using System;
using System.Media;
using System.Windows;

namespace WpfTutorialSamples.Audio_and_Video
{
	public partial class SystemSoundsSample : Window
	{
		public SystemSoundsSample()
		{
			InitializeComponent();			
		}

		private void btnAsterisk_Click(object sender, RoutedEventArgs e)
		{
			SystemSounds.Asterisk.Play();
		}

		private void btnBeep_Click(object sender, RoutedEventArgs e)
		{
			SystemSounds.Beep.Play();
		}

		private void btnExclamation_Click(object sender, RoutedEventArgs e)
		{
			SystemSounds.Exclamation.Play();
		}

		private void btnHand_Click(object sender, RoutedEventArgs e)
		{
			SystemSounds.Hand.Play();
		}

		private void btnQuestion_Click(object sender, RoutedEventArgs e)
		{
			SystemSounds.Question.Play();
		}
	}
}
