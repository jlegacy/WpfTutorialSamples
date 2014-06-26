using System;
using System.Windows;
using System.Collections.Generic;

namespace WpfTutorialSamples.ListBox_control
{
	public partial class ListBoxSelectionSample : Window
	{
		public ListBoxSelectionSample()
		{
			InitializeComponent();
			List<TodoItem> items = new List<TodoItem>();
			items.Add(new TodoItem() { Title = "Complete this WPF tutorial", Completion = 45 });
			items.Add(new TodoItem() { Title = "Learn C#", Completion = 80 });
			items.Add(new TodoItem() { Title = "Wash the car", Completion = 0 });

			lbTodoList.ItemsSource = items;
		}

		private void lbTodoList_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
		{
			if(lbTodoList.SelectedItem != null)
				this.Title = (lbTodoList.SelectedItem as TodoItem).Title;
		}

		private void btnShowSelectedItem_Click(object sender, RoutedEventArgs e)
		{
			foreach(object o in lbTodoList.SelectedItems)
				MessageBox.Show((o as TodoItem).Title);
		}

		private void btnSelectLast_Click(object sender, RoutedEventArgs e)
		{
			lbTodoList.SelectedIndex = lbTodoList.Items.Count - 1;
		}

		private void btnSelectNext_Click(object sender, RoutedEventArgs e)
		{
			int nextIndex = 0;
			if((lbTodoList.SelectedIndex >= 0) && (lbTodoList.SelectedIndex < (lbTodoList.Items.Count - 1)))
				nextIndex = lbTodoList.SelectedIndex + 1;
			lbTodoList.SelectedIndex = nextIndex;
		}

		private void btnSelectCSharp_Click(object sender, RoutedEventArgs e)
		{
			foreach(object o in lbTodoList.Items)
			{
				if((o is TodoItem) && ((o as TodoItem).Title.Contains("C#")))
				{
					lbTodoList.SelectedItem = o;
					break;
				}
			}
		}

		private void btnSelectAll_Click(object sender, RoutedEventArgs e)
		{
			foreach(object o in lbTodoList.Items)
				lbTodoList.SelectedItems.Add(o);
		}

		
	}

	public class TodoItem
	{
		public string Title { get; set; }
		public int Completion { get; set; }
	}
}
