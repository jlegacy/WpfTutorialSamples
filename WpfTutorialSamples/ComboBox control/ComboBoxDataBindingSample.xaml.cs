using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;

namespace WpfTutorialSamples.ComboBox_control
{
	public partial class ComboBoxDataBindingSample : Window
	{
		public ComboBoxDataBindingSample()
		{
			InitializeComponent();
			cmbColors.ItemsSource = typeof(Colors).GetProperties();
			//cmbColors.sele
		}
	}
}
