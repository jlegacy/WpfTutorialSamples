using System;
using System.ComponentModel;
using System.Threading;
using System.Windows;

namespace WpfTutorialSamples.Misc_controls
{
	public partial class ProgressBarTaskOnWorkerThread : Window
	{
		public ProgressBarTaskOnWorkerThread()
		{
			InitializeComponent();
		}

		private void Window_ContentRendered(object sender, EventArgs e)
		{
			BackgroundWorker worker = new BackgroundWorker();
			worker.WorkerReportsProgress = true;
			worker.DoWork += worker_DoWork;
			worker.ProgressChanged += worker_ProgressChanged;

			worker.RunWorkerAsync();
		}

		void worker_DoWork(object sender, DoWorkEventArgs e)
		{
			for(int i = 0; i < 100; i++)
			{
				(sender as BackgroundWorker).ReportProgress(i);
				Thread.Sleep(100);
			}
		}

		void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			pbStatus.Value = e.ProgressPercentage;
		}
	}
}
