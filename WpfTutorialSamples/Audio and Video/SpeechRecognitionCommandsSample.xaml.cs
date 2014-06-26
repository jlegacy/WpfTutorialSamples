using System;
using System.Globalization;
using System.Speech.Recognition;
using System.Windows;
using System.Windows.Media;

namespace WpfTutorialSamples.Audio_and_Video
{	
	public partial class SpeechRecognitionCommandsSample : Window
	{
		private SpeechRecognitionEngine speechRecognizer = new SpeechRecognitionEngine();

		public SpeechRecognitionCommandsSample()
		{
			InitializeComponent();			
			speechRecognizer.SpeechRecognized += speechRecognizer_SpeechRecognized;
			
			GrammarBuilder grammarBuilder = new GrammarBuilder();
			Choices commandChoices = new Choices("weight", "color", "size");
			grammarBuilder.Append(commandChoices);

			Choices valueChoices = new Choices();
			valueChoices.Add("normal", "bold");
			valueChoices.Add("red", "green", "blue");
			valueChoices.Add("small", "medium", "large");
			grammarBuilder.Append(valueChoices);

			speechRecognizer.LoadGrammar(new Grammar(grammarBuilder));
			speechRecognizer.SetInputToDefaultAudioDevice();			
		}

		private void btnToggleListening_Click(object sender, RoutedEventArgs e)
		{
			if(btnToggleListening.IsChecked == true)
				speechRecognizer.RecognizeAsync(RecognizeMode.Multiple);				
			else
				speechRecognizer.RecognizeAsyncStop();
		}

		private void speechRecognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
		{
			lblDemo.Content = e.Result.Text;
			if(e.Result.Words.Count == 2)
			{
				string command = e.Result.Words[0].Text.ToLower();
				string value = e.Result.Words[1].Text.ToLower();
				switch(command)
				{
					case "weight":
						FontWeightConverter weightConverter = new FontWeightConverter();						
						lblDemo.FontWeight = (FontWeight)weightConverter.ConvertFromString(value);						
						break;
					case "color":
						lblDemo.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(value));
						break;
					case "size":
						switch(value)
						{
							case "small":
								lblDemo.FontSize = 12;
								break;
							case "medium":
								lblDemo.FontSize = 24;
								break;
							case "large":
								lblDemo.FontSize = 48;
								break;
						}
						break;
				}
			}
		}

		private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			speechRecognizer.Dispose();
		}
	}
}
