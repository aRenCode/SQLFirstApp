using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
        Stopwatch stopwatch = new Stopwatch(); 
        //Timer time = new Timer();
        //System.Timers.Timer t;
        public Form1()
        {
            InitializeComponent();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            stopwatch.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ShowLabel.Text = String.Format("{0:00}:{1:00}:{2:000}", stopwatch.Elapsed.Minutes, 
                stopwatch.Elapsed.Seconds, stopwatch.Elapsed.Milliseconds) ;
             //ShowLabel.Text = stopwatch.Elapsed.Milliseconds.ToString(); 
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            TestLabel.Text = "1";
            string date = monthCalendar1.SelectionRange.Start.ToShortDateString() ;
            MessageBox.Show(date);
            notifyIcon1.Visible = true;
            notifyIcon1.Text = "WOW";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.BalloonTipText = "Hello STALKER";
            notifyIcon1.ShowBalloonTip(1000);
            
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Hello there!");
            notifyIcon1.BalloonTipText = "Hello STALKER";
            notifyIcon1.ShowBalloonTip(1000);
        }

        private void ShowLabel_Click(object sender, EventArgs e)
        {

        }

        private void TestLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
