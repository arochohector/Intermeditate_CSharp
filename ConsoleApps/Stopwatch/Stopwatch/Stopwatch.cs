using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch
{
    class Stopwatch
    {
        public TimeSpan Duration { get; set; }
        private DateTime _startTime { get; set; }
        private readonly DateTime _endTime;



        public void Start()
        {
            this._startTime = DateTime.Now;   
        }

        public void Stop()
        {

        }

    }
}
