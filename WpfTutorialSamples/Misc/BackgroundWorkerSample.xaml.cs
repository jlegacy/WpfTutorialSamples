using System;
using System.ComponentModel;
using System.Windows;

namespace WpfTutorialSamples.Misc
{
	public partial class BackgroundWorkerSample : Window
	{
		public BackgroundWorkerSample()
		{
			InitializeComponent();
		}

		private void btnDoSynchronousCalculation_Click(object sender, RoutedEventArgs e)
		{
			int max = 10000;
			pbCalculationProgress.Value = 0;
			lbResults.Items.Clear();

			int result = 0;
			for(int i = 0; i < max; i++)
			{
				if(i % 42 == 0)
				{
					lbResults.Items.Add(i);
					result++;
				}
				System.Threading.Thread.Sleep(1);
				pbCalculationProgress.Value = Convert.ToInt32(((double)i / max) * 100);
			}
			MessageBox.Show("Numbers between 0 and 10000 divisible by 7: " + result);
		}

		private void btnDoAsynchronousCalculation_Click(object sender, RoutedEventArgs e)
		{
			pbCalculationProgress.Value = 0;
			lbResults.Items.Clear();

			BackgroundWorker worker = new BackgroundWorker();
			worker.WorkerReportsProgress = true;
			worker.DoWork += worker_DoWork;
			worker.ProgressChanged += worker_ProgressChanged;
			worker.RunWorkerCompleted += worker_RunWorkerCompleted;
			worker.RunWorkerAsync(10000);
		}

		void worker_DoWork(object sender, DoWorkEventArgs e)
		{
			int max = (int)e.Argument;			
			int result = 0;
			for(int i = 0; i < max; i++)
			{
				int progressPercentage = Convert.ToInt32(((double)i / max) * 100);
				if(i % 42 == 0)
				{
					result++;
					(sender as BackgroundWorker).ReportProgress(progressPercentage, i);
				}
				else
					(sender as BackgroundWorker).ReportProgress(progressPercentage);
				System.Threading.Thread.Sleep(1);
				
			}
			e.Result = result;
		}	

		void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			pbCalculationProgress.Value = e.ProgressPercentage;
			if(e.UserState != null)
				lbResults.Items.Add(e.UserState);
		}
		
		void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			MessageBox.Show("Numbers between 0 and 10000 divisible by 7: " + e.Result);
		}

	}	
}
