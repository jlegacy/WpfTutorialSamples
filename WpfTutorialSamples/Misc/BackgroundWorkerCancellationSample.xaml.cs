using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Media;

namespace WpfTutorialSamples.Misc
{
	public partial class BackgroundWorkerCancellationSample : Window
	{
		private BackgroundWorker worker = null;

		public BackgroundWorkerCancellationSample()
		{
			InitializeComponent();
			worker = new BackgroundWorker();
			worker.WorkerSupportsCancellation = true;
			worker.WorkerReportsProgress = true;
			worker.DoWork += worker_DoWork;
			worker.ProgressChanged += worker_ProgressChanged;
			worker.RunWorkerCompleted += worker_RunWorkerCompleted;
		}

		private void btnStart_Click(object sender, RoutedEventArgs e)
		{
			worker.RunWorkerAsync();
		}

		private void btnCancel_Click(object sender, RoutedEventArgs e)
		{
			worker.CancelAsync();
		}

		void worker_DoWork(object sender, DoWorkEventArgs e)
		{
			for(int i = 0; i <= 100; i++)
			{
				if(worker.CancellationPending == true)
				{
					e.Cancel = true;
					return;
				}
				worker.ReportProgress(i);
				System.Threading.Thread.Sleep(250);
			}
			e.Result = 42;
		}

		void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			lblStatus.Text = "Working... (" + e.ProgressPercentage + "%)";
		}

		void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			if(e.Cancelled)
			{
				lblStatus.Foreground = Brushes.Red;
				lblStatus.Text = "Cancelled by user...";
			}
			else
			{
				lblStatus.Foreground = Brushes.Green;
				lblStatus.Text = "Done... Calc result: " + e.Result;
			}
		}		
	}
}
