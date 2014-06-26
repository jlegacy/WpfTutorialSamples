using System;
using System.Collections.Generic;
using System.Windows;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace WpfTutorialSamples.DataBinding
{
	public partial class ChangeNotificationSample : Window
	{
        public List<string> Genders { get; set; }

		private ObservableCollection<User> users = new ObservableCollection<User>();

		public ChangeNotificationSample()
		{
			InitializeComponent();
			
			users.Add(new User() { Name = "John Doe", Age = 25, Gender="male"});
			users.Add(new User() { Name = "Jane Doe", Age = 30, Gender="female"});

			lbUsers.ItemsSource = users;

            Genders = new List<string>();
            Genders.Add("male");
            Genders.Add("female");

            Gender.ItemsSource = Genders;

		}

		private void btnAddUser_Click(object sender, RoutedEventArgs e)
		{
			users.Add(new User() { Name = "New user", Age = 25});
		}

		private void btnChangeUser_Click(object sender, RoutedEventArgs e)
		{
			foreach(var x in users) {
               
                MessageBox.Show(x.Gender);
            }
            
            //if(lbUsers.SelectedItem != null)
			//	(lbUsers.SelectedItem as User).Name = "Random Name";
		}

		private void btnDeleteUser_Click(object sender, RoutedEventArgs e)
		{
			if(lbUsers.SelectedItem != null)
				users.Remove(lbUsers.SelectedItem as User);
		}
	}

	public class User : INotifyPropertyChanged
	{
		private string name;
		public string Name {
			get { return this.name; }
			set
			{
				if(this.name != value)
				{
					this.name = value;
					this.NotifyPropertyChanged("Name");
				}
			}
		}

        private int age;
        public int Age
        {
            get { return this.age; }
            set
            {
                if (this.age != value)
                {
                    this.age = value;
                    this.NotifyPropertyChanged("Age");
                }
            }
        }

        private string gender;
        public string Gender
        {
            get { return this.gender; }
            set
            {
                if (this.gender != value)
                {
                    this.gender = value;
                    this.NotifyPropertyChanged("Gender");
                }
            }
        }



		public event PropertyChangedEventHandler PropertyChanged;

		public void NotifyPropertyChanged(string propName)
		{
			if(this.PropertyChanged != null)
				this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
		}
	}
}
