using System;
using System.Speech.Synthesis;
using System.Windows;

namespace WpfTutorialSamples.Audio_and_Video
{
	public partial class SpeechSynthesisPromptBuilderSample : Window
	{
		public SpeechSynthesisPromptBuilderSample()
		{
			InitializeComponent();
		}

		private void btnSayHello_Click(object sender, RoutedEventArgs e)
		{
			PromptBuilder promptBuilder = new PromptBuilder();
			promptBuilder.AppendText("Hello world");
			
			PromptStyle promptStyle = new PromptStyle();
			promptStyle.Volume = PromptVolume.Soft;
			promptStyle.Rate = PromptRate.Slow;
			promptBuilder.StartStyle(promptStyle);
			promptBuilder.AppendText("and hello to the universe too.");
			promptBuilder.EndStyle();

			promptBuilder.AppendText("On this day, ");
			promptBuilder.AppendTextWithHint(DateTime.Now.ToShortDateString(), SayAs.Date);

			promptBuilder.AppendText(", we're gathered here to learn");
			promptBuilder.AppendText("all", PromptEmphasis.Strong);
			promptBuilder.AppendText("about");
			promptBuilder.AppendTextWithHint("WPF", SayAs.SpellOut);

			SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
			speechSynthesizer.Speak(promptBuilder);
		}
	}
}
