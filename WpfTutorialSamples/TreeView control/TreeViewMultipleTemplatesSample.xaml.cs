using System;
using System.Collections.Generic;
using System.Windows;
using System.Collections.ObjectModel;

namespace WpfTutorialSamples.TreeView_control
{
	public partial class TreeViewMultipleTemplatesSample : Window
	{
		public TreeViewMultipleTemplatesSample()
		{
			InitializeComponent();

			List<Family> families = new List<Family>();

			Family family1 = new Family() { Name = "The Doe's" };
			family1.Members.Add(new FamilyMember() { Name = "John Doe", Age = 42 });
			family1.Members.Add(new FamilyMember() { Name = "Jane Doe", Age = 39 });
			family1.Members.Add(new FamilyMember() { Name = "Sammy Doe", Age = 13 });
			families.Add(family1);

			Family family2 = new Family() { Name = "The Moe's" };
			family2.Members.Add(new FamilyMember() { Name = "Mark Moe", Age = 31 });
			family2.Members.Add(new FamilyMember() { Name = "Norma Moe", Age = 28 });
			families.Add(family2);

			trvFamilies.ItemsSource = families;
		}
	}

	public class Family
	{
		public Family()
		{
			this.Members = new ObservableCollection<FamilyMember>();
		}

		public string Name { get; set; }

		public ObservableCollection<FamilyMember> Members { get; set; }
	}

	public class FamilyMember
	{
		public string Name { get; set; }

		public int Age { get; set; }
	}
}