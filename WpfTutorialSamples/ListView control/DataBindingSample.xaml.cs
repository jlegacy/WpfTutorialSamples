using System;
using System.Collections.Generic;
using System.Windows;

namespace WpfTutorialSamples.ListView_control
{
	public partial class DataBindingSample : Window
	{
		public DataBindingSample()
		{
			InitializeComponent();
			List<User> items = new List<User>();
			items.Add(new User() { Name = "John Doe", Age = 42 });
			items.Add(new User() { Name = "Jane Doe", Age = 39 });
			items.Add(new User() { Name = "Sammy Doe", Age = 13 });
			lvDataBinding.ItemsSource = items;
		}
	}

	/*public class User
	{
		public string Name { get; set; }

		public int Age { get; set; }

		public override string ToString()
		{
			return this.Name + ", " + this.Age + " years old";
		}
	}*/
}
