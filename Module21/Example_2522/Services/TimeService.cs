using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example_2522.Services
{
    public class TimeService : IService
    {
        public string GetData()
        {
            return DateTime.Now.ToLongTimeString();
        }
    }
}
