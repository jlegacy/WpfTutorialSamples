using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Reflection;
using System.ComponentModel;
using System.Threading;
using System.Globalization;

namespace WpfTutorialSamples
{
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			Thread.CurrentThread.CurrentCulture = (App.Current as App).SystemDefaultCulture;

			List<TutorialSample> samples = new List<TutorialSample>();
			Assembly assembly = Assembly.GetExecutingAssembly();
			Type[] types = assembly.GetTypes().Where(t => t.BaseType.Name == "Window").ToArray();
			foreach(Type type in types)
			{				
				List<string> nameParts = type.FullName.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries).ToList();
				if((nameParts[0] == "WpfTutorialSamples") && (nameParts.Count == 3))
				{
					samples.Add(new TutorialSample() 
					{ 
						Category = nameParts[1].Replace("_", " "),
						Name = nameParts[2],
						TypeInfo = type
					});
				}
			}			
			lbSamples.ItemsSource = samples;
			lbSamples.Items.GroupDescriptions.Add(new PropertyGroupDescription("Category"));
		}

		private void lbSamples_MouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
			if((lbSamples.SelectedItem != null) && (lbSamples.SelectedItem is TutorialSample)) 
			{
				Type windowType = (lbSamples.SelectedItem as TutorialSample).TypeInfo;
				object wnd = Activator.CreateInstance(windowType);
				if(wnd != null)
					(wnd as Window).Show();
			}
		}

	}

	public class TutorialSample
	{
		public string Name { get; set; }

		public string Category { get; set; }

		public Type TypeInfo { get; set; }
	}
}
