using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_07
{
    struct Diary
    {
        private Record[] Records;

        public string this[DateTime dateTime]
        {
            get
            {
                for (int i = 0; i < Records.Length; i++)
                {
                    if (Records[i].Date + Records[i].Time == dateTime || Records[i].Date == dateTime)
                    {
                        return Records[i].GetInfoRecord();
                    }
                }
                return "На данную дату ничего не запланированно!";
            }
        }
    }
}
