using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace WpfTutorialSamples.DataBinding
{
	public partial class DataContextSample : Window
	{
		public DataContextSample()
		{
			InitializeComponent();
			this.DataContext = this;
		}

		private void btnUpdateSource_Click(object sender, RoutedEventArgs e)
		{
			BindingExpression binding = txtWindowTitle.GetBindingExpression(TextBox.TextProperty);
			binding.UpdateSource();
		}
	}
}
