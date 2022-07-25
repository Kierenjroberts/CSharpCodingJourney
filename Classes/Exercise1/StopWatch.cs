using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class StopWatch
    {
        public string beginningWatch;
        public string endingWatch;

        public DateTime Start()
        {
            var startTime = new DateTime();

            if (String.IsNullOrWhiteSpace(beginningWatch))
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

            if (String.IsNullOrWhiteSpace(endingWatch))
            {
                endTime = DateTime.Now;
                duration = endTime - initialTime;
            }

            return duration;
        }
    }
}
