using System;
using System.Diagnostics;
using System.Windows.Forms;



namespace AllClasses
{
    
    public class ElapseCalculator
    {
        public static Stopwatch watch = new Stopwatch();
        public string textTimerElapsed { get; set; } = "00:00:000";

        public System.Timers.Timer t = new System.Timers.Timer();
        public ElapseCalculator() {
            
            t.Interval = 100;
            t.Elapsed += t_Tick;

            t.Start();
            watch.Start();

            
        }
        private void t_Tick(object sender, EventArgs e) {
            //Console.WriteLine(String.Format("{0:00}:{1:00}:{2:000}", watch.Elapsed.Minutes, watch.Elapsed.Seconds
            //        , watch.Elapsed.Milliseconds));
            if(!watch.IsRunning)
            {
                watch.Reset();
                t.Stop();
            }
            
        }
    }
}
