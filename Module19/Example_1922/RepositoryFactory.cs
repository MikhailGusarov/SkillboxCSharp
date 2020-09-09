using System;
using System.Collections.Generic;

namespace Example_1922
{
    class RepositoryFactory
    {
        static Random r;
        static RepositoryFactory() { r = new Random(); }

        public static Repository GetRepository(int Count)
        {

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

            return new Repository(temp);
        }
    }
}