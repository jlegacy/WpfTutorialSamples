using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;

namespace WpfTutorialSamples.ComboBox_control
{
	public partial class DataBindingSample : Window
	{
		public DataBindingSample()
		{
			InitializeComponent();
			cmbColors.ItemsSource = typeof(Colors).GetProperties();
		}
	}
}
