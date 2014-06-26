using System;
using System.Windows;
using System.Collections.Generic;

namespace WpfTutorialSamples.ListBox_control
{
	public partial class ListBoxDataBindingSample : Window
	{
		public ListBoxDataBindingSample()
		{
			InitializeComponent();
			List<TodoItem> items = new List<TodoItem>();
			items.Add(new TodoItem() { Title = "Complete this WPF tutorial", Completion = 45 });
			items.Add(new TodoItem() { Title = "Learn C#", Completion = 80 });
			items.Add(new TodoItem() { Title = "Wash the car", Completion = 0 });

			lbTodoList.ItemsSource = items;
		}
	}
	/*
	public class TodoItem
	{
		public string Title { get; set; }
		public int Completion { get; set; }
	}*/
}
