using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Data;

namespace WpfTutorialSamples.DataGrid_control
{
	public partial class DataGridGroupSample : Window
	{
		public DataGridGroupSample()
		{
			InitializeComponent();
			List<User> users = new List<User>();
			users.Add(new User() { Id = 1, Name = "John Doe", Birthday = new DateTime(1971, 7, 23), Sex = SexType.Male });
			users.Add(new User() { Id = 2, Name = "Jane Doe", Birthday = new DateTime(1974, 1, 17), Sex = SexType.Female });
			users.Add(new User() { Id = 3, Name = "Sammy Doe", Birthday = new DateTime(1991, 9, 2), Sex = SexType.Male });

			dgUsers.ItemsSource = users;

			CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(dgUsers.ItemsSource);
			PropertyGroupDescription groupDescription = new PropertyGroupDescription("Sex");
			view.GroupDescriptions.Add(groupDescription);
		}
	}

	public enum SexType { Male, Female };

	public class User
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public DateTime Birthday { get; set; }

		public string ImageUrl { get; set; }

		public SexType Sex { get; set; }
	}
}
