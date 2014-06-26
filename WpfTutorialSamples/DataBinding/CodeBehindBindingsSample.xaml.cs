using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace WpfTutorialSamples.DataBinding
{
	public partial class CodeBehindBindingsSample : Window
	{
		public CodeBehindBindingsSample()
		{
			InitializeComponent();

			Binding binding = new Binding("Text");
			binding.Source = txtValue;			
			lblValue.SetBinding(TextBlock.TextProperty, binding);
		}
	}
}
