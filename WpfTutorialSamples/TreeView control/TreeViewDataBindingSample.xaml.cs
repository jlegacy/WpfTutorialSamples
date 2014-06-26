using System;
using System.Collections.Generic;
using System.Windows;
using System.IO;
using System.Collections.ObjectModel;

namespace WpfTutorialSamples.TreeView_control
{
	public partial class TreeViewDataBindingSample : Window
	{
		public TreeViewDataBindingSample()
		{
			InitializeComponent();
			MenuItem root = new MenuItem() { Title = "Menu" };
			MenuItem childItem1 = new MenuItem() { Title = "Child item #1" };
			childItem1.Items.Add(new MenuItem() { Title = "Child item #1.1" });
			childItem1.Items.Add(new MenuItem() { Title = "Child item #1.2" });
			root.Items.Add(childItem1);
			root.Items.Add(new MenuItem() { Title = "Child item #2" });			
			trvMenu.Items.Add(root);
		}
	}

	public class MenuItem
	{
		public MenuItem()
		{
			this.Items = new ObservableCollection<MenuItem>();
		}

		public string Title { get; set; }

		public ObservableCollection<MenuItem> Items { get; set; }
	}

}
