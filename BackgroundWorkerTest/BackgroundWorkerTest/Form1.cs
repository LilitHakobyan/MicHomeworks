using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackgroundWorkerTest
{
    public partial class Form1 : Form
    {
        BackgroundWorker bw = new BackgroundWorker();
        int i = 0;
        long sum = 0;
        private bool pause;
        const long Max = (long)1E09;

        public Form1()
        {
            InitializeComponent();
           
            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;

            bw.DoWork += Bw_DoWork;
            bw.ProgressChanged += Bw_ProgressChanged;
            bw.RunWorkerCompleted += Bw_RunWorkerCompleted;
        }

        private void Bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show(e.Result?.ToString());
        }

        private void Bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar1.Value = e.ProgressPercentage;
            this.textBox1.Text = e.UserState?.ToString();
        }

        private void Bw_DoWork(object sender, DoWorkEventArgs e)
        {
            for (; i <= Max; i++)
            {
                sum += i;

                if (bw.CancellationPending)
                {
                   
                    e.Result = "Cancelled by user";
                    return;
                }

                if (i % 100000 == 0)
                {
                    
                    this.bw.ReportProgress((int)(((double)i / Max) * 100), sum);
                    if (i == Max)
                    {
                        sum = 0;
                        i = 0;
                        e.Result = "Finish";
                        return;
                    }

                }
            }

            e.Result = sum;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!bw.IsBusy)
            {
                bw.RunWorkerAsync();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
           sum = 0;
            i = 0;
            this.progressBar1.Value = 0;
            this.textBox1.Text = "";
        }

        

        private void btnPause_Click(object sender, EventArgs e)
        {
            bw.CancelAsync();
            
        }
    }
}
