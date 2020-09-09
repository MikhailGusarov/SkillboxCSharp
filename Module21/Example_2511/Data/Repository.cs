using Example_2511.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example_2511.Data
{
    public static class Repository
    {
        static string[] names;
        static Random rand;
        static Repository()
        {
            names = new string[] { "Денис", "Людмила", "Иван", "Альбина" };
            rand = new Random();
        }

        public static Worker GetWorker()
        {
            string name = names[rand.Next(names.Length)];
            int age = rand.Next(14, 99);
            int salary = rand.Next(5, 10) * 1000;

            return new Worker()
            {
                Name = name,
                Age = age,
                Salary = salary,
            };
        }

    }
}
