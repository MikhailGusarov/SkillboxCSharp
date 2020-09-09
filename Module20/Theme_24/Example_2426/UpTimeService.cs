using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example_2426
{
    public interface IUpTimeService
    {
        string UpTimeSpan { get; }
    }
    public class UpTimeServiceSecond: IUpTimeService
    {
        DateTime timeStart;

        public UpTimeServiceSecond()
        {
            timeStart = DateTime.Now;
        }

        public string UpTimeSpan { get { return $"{(int)(DateTime.Now - timeStart).TotalSeconds} s."; } }
    }

    public class UpTimeServiceMinutes : IUpTimeService
    {
        DateTime timeStart;

        public UpTimeServiceMinutes()
        {
            timeStart = DateTime.Now;
        }

        public string UpTimeSpan { get { return $"{(DateTime.Now - timeStart).TotalMinutes} m."; } }
    }
}
