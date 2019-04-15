using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace WindowsService1
{
    public partial class SampleService01 : ServiceBase
    {
        public SampleService01()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            // Set up a timer that triggers every 15 seconds.
            Timer timer = new Timer();
            timer.Interval = 15000; // 15 seconds
            timer.Elapsed += new ElapsedEventHandler(this.OnTimer);
            timer.Start();
        }

        public void OnTimer(object sender, ElapsedEventArgs args)
        {
            // TODO: Do some activitiy here.
            using (EventLog eventLog = new EventLog("Application"))
            {
                eventLog.Source = "Application";
                eventLog.WriteEntry("Doing some action on timer in the SampleService01", EventLogEntryType.Information);
            }
        }

        protected override void OnStop()
        {
        }
    }
}
