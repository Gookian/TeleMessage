using System;
using System.Diagnostics;

namespace Server.ChatBot
{
    class Timer
    {
        private Stopwatch stopwatch = new Stopwatch();

        public int Hour
        {
            get { return stopwatch.Elapsed.Hours; }
        }

        public int Minute
        {
            get { return stopwatch.Elapsed.Minutes; }
        }

        public int Second
        {
            get { return stopwatch.Elapsed.Seconds; }
        }

        public string Time()
        {
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
