using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Example_1921
{
    class Program
    {
        static void Main(string[] args)
        {
            // Фабрика – это объект имеющий функционал, производящий продукты. 

            Random r = new Random();

            Repository mainDepartment = new Repository();

            for (int i = 0; i < 10; i++)
            {
                switch (r.Next(3))
                {
                    case 1: mainDepartment.Add(new Accountant($"Бухгалтер","Оплата труда", "Имя")); break;
                    case 2: mainDepartment.Add(new HrManager($"Менеджер по персоналу","Оплата труда", "Имя")); break;
                    default: mainDepartment.Add(new Courier($"Курьер", "Оплата труда", "Имя")); break;
                }
            }

            mainDepartment.PeintRepository();

            Console.WriteLine("\n---\n");

            Repository otherDepartment;

            List<IWorker> temp = new List<IWorker>();

            for (int i = 0; i < 10; i++)
            {
                switch (r.Next(3))
                {
                    case 1: temp.Add(new Accountant($"Бухгалтер", "Оплата труда", "Имя")); break;
                    case 2: temp.Add(new HrManager($"Менеджер по персоналу", "Оплата труда", "Имя")); break;
                    default: temp.Add(new Courier($"Курьер", "Оплата труда", "Имя")); break;
                }
            }
            
            otherDepartment = new Repository(temp);

            otherDepartment.PeintRepository();



        }
    }
}
