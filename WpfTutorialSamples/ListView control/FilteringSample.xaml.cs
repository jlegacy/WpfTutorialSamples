using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Data;

namespace WpfTutorialSamples.ListView_control
{
	public partial class FilteringSample : Window
	{
		public FilteringSample()
		{
			InitializeComponent();
			List<User> items = new List<User>();
			items.Add(new User() { Name = "John Doe", Age = 42 });
			items.Add(new User() { Name = "Jane Doe", Age = 39 });			
			items.Add(new User() { Name = "Sammy Doe", Age = 13 });
			items.Add(new User() { Name = "Donna Doe", Age = 13 });
			lvUsers.ItemsSource = items;
			
			CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lvUsers.ItemsSource);
			view.Filter = UserFilter;
		}

		private bool UserFilter(object item)
		{
			if(String.IsNullOrEmpty(txtFilter.Text))
				return true;
			else
				return ((item as User).Name.IndexOf(txtFilter.Text, StringComparison.OrdinalIgnoreCase) >= 0);
		}

		private void txtFilter_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
		{
			CollectionViewSource.GetDefaultView(lvUsers.ItemsSource).Refresh();
		}
	}

	public enum SexType { Male, Female };

	public class User
	{
		public string Name { get; set; }

		public int Age { get; set; }

		public string Mail { get; set; }

		public SexType Sex { get; set; }
	}
}
