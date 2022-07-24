using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class StopWatch
    {
        public string initialiseWatch;
        public string endWatch;

        public DateTime Start()
        {
            var startTime = new DateTime();

            if (String.IsNullOrWhiteSpace(initialiseWatch))
            {
                startTime = DateTime.Now;
            }

            return startTime;
        }

        public TimeSpan StopAndCalculateDuration(DateTime startTime)
        {
            var endTime = new DateTime();
            var initialTime = startTime;
            var duration = new TimeSpan();

            if (String.IsNullOrWhiteSpace(endWatch))
            {
                duration = endTime - initialTime;
            }

            return duration;
        }
    }
}
