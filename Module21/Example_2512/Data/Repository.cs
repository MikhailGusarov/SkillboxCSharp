using Example_2512.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example_2512.Data
{
    public static class Repository
    {
        static string[] names;
        static string[] companys;
 
        static Random rand;
        static Repository()
        {
            names = new string[] { "Денис", "Людмила", "Иван", "Альбина" };
            companys = new string[] { "Apple", "Microsoft", "Svetlyakov Inc.", "Safonovo Jbi Inc." };
            rand = new Random();
        }

        public static Worker GetWorker()
        {
            string name = names[rand.Next(names.Length)];
            string company = companys[rand.Next(names.Length)];

            int age = rand.Next(14, 99);
            int salary = rand.Next(5, 10) * 1000;

            return new Worker()
            {
                Name = name,
                Age = age,
                Salary = salary,
                Company = company
            };
        }

        public static List<Worker> GetWorkers()
        {
            List<Worker> db = new List<Worker>();

            for (int i = 0; i < 10; i++)
            {
                db.Add(GetWorker());
            }
            return db;
        }

        public static List<string> GetTitles()
        {
            return new List<string>() { "Заголовок 1", "Заголовок 2", "Заголовок 3", "Заголовок 4" };
        }

    }
}
