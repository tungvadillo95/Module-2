using System;
namespace BT_stop_watch
{
    public class StopWatch
    {
        private DateTime startTime;
        private DateTime endTime;
        public void Star()
        {
            startTime = DateTime.Now;
        }
        public void Stop()
        {
            endTime = DateTime.Now;
        }
        public double GetElapsedTime()
        {
            return (endTime - startTime).TotalMilliseconds;

        }
    }
}
