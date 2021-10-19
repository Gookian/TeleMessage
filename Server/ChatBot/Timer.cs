using System;
using System.Diagnostics;

namespace Server.ChatBot
{
    class Timer
    {
        private Stopwatch stopwatch = new Stopwatch();

        public string Time()
        {
            //int hours;
            //int Minutes;
            //int seconds;
            return Convert.ToString(stopwatch.Elapsed.Hours + ":" + stopwatch.Elapsed.Minutes + ":" + stopwatch.Elapsed.Seconds);
        }

        public void Start()
        {
            stopwatch.Start();
        }

        public void Stop()
        {
            stopwatch.Stop();
        }
    }
}
