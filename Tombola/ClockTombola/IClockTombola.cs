using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockTombola
{
    public interface IClockTombola
    {
        void Start();
        void Stop();
        void Next();
        void SetStep(int millis);
        int GetStep();
        uint GetTicks();
        string GetDuration();
    }
}
