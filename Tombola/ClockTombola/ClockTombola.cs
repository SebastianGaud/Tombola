using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClockTombola
{
    public class ClockTombola : IClockTombola
    {
        private int STEP = 5000;
        private DateTime? start, end;
        private uint ticks;

        private void ResetClock()
        {
            start = null;
            end = null;
            ticks = 0;
        }

        public uint GetTicks()
        {
            return ticks;
        }

        public ClockTombola()
        {
            ResetClock();
        }

        public int GetStep()
        {
            return STEP;
        }

        public void Next()
        {
            Thread.Sleep(STEP);
            ticks++;
        }

        public void SetStep(int millis)
        {
             if(millis > 0)
                STEP = millis;
        }

        public void Start()
        {
            ResetClock();

            start = DateTime.Now;
        }

        public void Stop()
        {
            end = DateTime.Now;
        }

        public string GetDuration()
        {
            if (start == null || end == null)
                return null;

            return (end - start).Value.ToString("c");
        }
    }
}
