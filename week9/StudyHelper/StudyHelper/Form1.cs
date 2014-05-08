using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace StudyHelper
{
    public partial class Form1 : Form
    {
        private Timer now = new Timer();
        private bool flag = false;
        private SoundPlayer sp;

        public Form1()
        {
            InitializeComponent();
            sp = new SoundPlayer(Properties.Resources.bell);
            if (rBtn_watch.Checked == true)
            {
                StartWatch();
            }
        }

        private void btn_cfrm_Click(object sender, EventArgs e)
        {
            if(rBtn_stopWatch.Checked == true)
            {
                if (flag == false)
                {
                    flag = true;
                    now = new Timer();
                    now.Interval = 10;
                    now.Tick += new System.EventHandler(SWatchCheck);
                    now.Start();
                }
                else
                    flag = false;
            }
            else if(rBtn_timer.Checked == true)
            {
                if (flag == false)
                {
                    flag = true;
                    TimerAlarm.ChgText(tBox_entTime.Text);
                    now = new Timer();
                    now.Interval = 1000;
                    now.Tick += new System.EventHandler(TimerCheck);
                    now.Start();
                }
            }
        }

        private void btn_rst_Click(object sender, EventArgs e)
        {
            if(rBtn_stopWatch.Checked == true)
            {
                now.Stop();
                StopWatch.Reset();
                flag = false;
            }
            else if(rBtn_timer.Checked == true)
            {
                now.Stop();
                sp.Stop();
                flag = false;
            }
            ResetLbTimer();
        }

        private void StartWatch()
        {
            lb_timer.Text = Watch.ThisTime();
            now = new Timer();
            now.Interval = 1000;
            now.Tick += new System.EventHandler(TimeCheck);
            now.Start();
        }

        private void ResetLbTimer()
        {
            lb_timer.Text = "00:00:00";
        }

        private void TimeCheck(object sender, EventArgs e)
        {
            if (rBtn_watch.Checked != true)
                now.Stop();
            else
            {
                lb_timer.Text = Watch.ThisTime();
            }
        }

        private void SWatchCheck(object sender, EventArgs e)
        {
            if (rBtn_stopWatch.Checked != true)
                this.now.Stop();
            else
            {
                string now = StopWatch.Start();
                if (flag == true)
                    lb_timer.Text = now;
            }
        }

        private void TimerCheck(object sender, EventArgs e)
        {
            if (rBtn_timer.Checked != true)
                this.now.Stop();
            else
            {
                string now = TimerAlarm.Start();
                lb_timer.Text = now;
                if (TimerAlarm.H == 0 && TimerAlarm.M == 0 && TimerAlarm.S == 0)
                {
                    TimerAlarm.PlayBell(sp);
                    this.now.Stop();
                }
            }
        }

        private void rBtn_watch_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtn_watch.Checked == true)
            {
                now.Stop();
                StopWatch.Reset();
                ResetLbTimer();
                StartWatch();
            }
        }

        private void rBtn_stopWatch_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtn_stopWatch.Checked == true)
            {
                now.Stop();
                flag = false;
                ResetLbTimer();
            }
        }

        private void rBtn_timer_CheckedChanged(object sender, EventArgs e)
        {
            if(rBtn_timer.Checked == true)
            {
                now.Stop();
                StopWatch.Reset();
                ResetLbTimer();
            }
        }
    }

    public class Watch
    {
        public static string ThisTime()
        {
            int h = DateTime.Now.Hour;
            int m = DateTime.Now.Minute;
            int s = DateTime.Now.Second;
            string now = String.Format("{0:00}:{1:00}:{2:00}", h, m, s);
            return now;
        }
    }

    public class StopWatch
    {
        static int m;
        static int s;
        static int ms;
        public static string Start()
        {
            ms++;
            if (ms == 100)
            {
                ms = 0;
                s++;
            }
            if (s == 60)
            {
                s = 0;
                m++;
            }
            if (m == 100)
            {
                m = 0;
            }
            string now = String.Format("{0:00}:{1:00}:{2:00}", m, s, ms);
            return now;
        }
        public static void Reset()
        {
            m = 0;
            s = 0;
            ms = 0;
        }
    }

    public class TimerAlarm
    {
        static int h;
        static int m;
        static int s;
        public static string Start()
        {
            s--;
            if(s == -1)
            {
                m--;
                s = 59;
            }
            if(m == -1)
            {
                h--;
                m = 59;
            }
            string now = String.Format("{0:00}:{1:00}:{2:00}", h, m, s);
            return now;
        }
        public static void PlayBell(SoundPlayer sp)
        {
            sp.PlayLooping();
        }
        public static void StopBell(SoundPlayer sp)
        {
            sp.Stop();
        }
        public static void ChgText(String time)
        {
            string[] times = time.Split(':');
            h = Convert.ToInt32(times[0]);
            m = Convert.ToInt32(times[1]);
            s = Convert.ToInt32(times[2]);
        }
        public static int H 
        {
            get{return h;}
        }
        public static int M
        {
            get { return m; }
        }
        public static int S
        {
            get { return s; }
        }
    }
}
