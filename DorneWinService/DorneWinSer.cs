using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace DorneWinService
{
    public partial class DorneWinSer : ServiceBase
    {
        Timer timer = new Timer(); // name space(using System.Timers;)  

        public DorneWinSer()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            EventLog.WriteEntry("Dorne Windows Service", "Service Starting....", EventLogEntryType.Information);
            WriteToFile("Service is started at " + DateTime.Now);
            timer.Elapsed += new ElapsedEventHandler(OnElapsedTime);
            timer.Interval = 5000; //number in miliseconds  
            timer.Enabled = true;
        }

        protected override void OnStop()
        {
            EventLog.WriteEntry("Dorne Windows Service", "Service Stopping....", EventLogEntryType.Information);
        }
        private void OnElapsedTime(object source, ElapsedEventArgs e)
        {
            //WriteToFile("Dorne Windows Service is recall at " + DateTime.Now);
            TCMB();
        }

        //For more information go to -> https://dzone.com/articles/create-windows-services-in-c
        public void WriteToFile(string Message)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "\\Logs";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string filepath = AppDomain.CurrentDomain.BaseDirectory + "\\Logs\\ServiceLog_" + DateTime.Now.Date.ToShortDateString().Replace('/', '_') + ".txt";
            if (!File.Exists(filepath))
            {
                // Create a file to write to.   
                using (StreamWriter sw = File.CreateText(filepath))
                {
                    sw.WriteLine(Message);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(filepath))
                {
                    sw.WriteLine(Message);
                }
            }
        }

        public void TCMB()
        {
            try
            {
                const string url = "http://www.tcmb.gov.tr/kurlar/today.xml";

                string xmlStr;

                using (var wc = new WebClient())
                {
                    xmlStr = wc.DownloadString(url);
                }

                WriteToFile(xmlStr);
            }
            catch (Exception ex)
            {

                EventLog.WriteEntry("Dorne Windows Service", "Message="+ex.Message+"StackTrace="+ex.StackTrace, EventLogEntryType.Warning);
            }
        }
    }
}
