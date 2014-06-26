using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace WpfTutorialSamples.TreeView_control
{
	public partial class LazyLoadingSample : Window
	{
		public LazyLoadingSample()
		{
			InitializeComponent();
			DriveInfo[] drives = DriveInfo.GetDrives();
			foreach(DriveInfo driveInfo in drives)
				trvStructure.Items.Add(CreateTreeItem(driveInfo));
		}

		public void TreeViewItem_Expanded(object sender, RoutedEventArgs e)
		{			
			TreeViewItem item = e.Source as TreeViewItem;
			if((item.Items.Count == 1) && (item.Items[0] is string))
			{
				item.Items.Clear();

				DirectoryInfo expandedDir = null;
				if(item.Tag is DriveInfo)
					expandedDir = (item.Tag as DriveInfo).RootDirectory;
				if(item.Tag is DirectoryInfo)
					expandedDir = (item.Tag as DirectoryInfo);
				try
				{
					foreach(DirectoryInfo subDir in expandedDir.GetDirectories())
						item.Items.Add(CreateTreeItem(subDir));
				}
				catch { }
			}
		}

		private TreeViewItem CreateTreeItem(object o)
		{
			TreeViewItem item = new TreeViewItem();
			item.Header = o.ToString();
			item.Tag = o;
			item.Items.Add("Loading...");
			return item;
		}
	}
}
