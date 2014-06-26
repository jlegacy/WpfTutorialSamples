using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Data;

namespace WpfTutorialSamples.ListView_control
{
	public partial class SortingSample : Window
	{
		public SortingSample()
		{
			InitializeComponent();
			List<User> items = new List<User>();
			items.Add(new User() { Name = "John Doe", Age = 42 });
			items.Add(new User() { Name = "Jane Doe", Age = 39 });			
			items.Add(new User() { Name = "Sammy Doe", Age = 13 });
			items.Add(new User() { Name = "Donna Doe", Age = 13 });
			lvUsers.ItemsSource = items;

			CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lvUsers.ItemsSource);
			view.SortDescriptions.Add(new SortDescription("Age", ListSortDirection.Ascending));
			view.SortDescriptions.Add(new SortDescription("Name", ListSortDirection.Ascending));			
		}
	}

	/*public enum SexType { Male, Female };

	public class User
	{
		public string Name { get; set; }

		public int Age { get; set; }

		public string Mail { get; set; }

		public SexType Sex { get; set; }
	}*/
}
