using System;
using System.Windows;
using System.Windows.Media;

namespace WpfTutorialSamples.Misc_controls
{
	public partial class SliderValueChangedSample : Window
	{
		public SliderValueChangedSample()
		{
			InitializeComponent();
		}

		private void ColorSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			Color color = Color.FromRgb((byte)slColorR.Value, (byte)slColorG.Value, (byte)slColorB.Value);
			this.Background = new SolidColorBrush(color);
		}
	}
}
