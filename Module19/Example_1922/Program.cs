using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_1922
{
    class Program
    {
        static void Main(string[] args)
        {
            #region _

            //Random r = new Random();

            //Repository mainDepartment = new Repository();

            //for (int i = 0; i < 10; i++)
            //{
            //    switch (r.Next(3))
            //    {
            //        case 1: mainDepartment.Add(WorkerFactory.GetWorker("Accountant", "Бухгалтер", "Оплата труда", "Имя")); break;
            //        case 2: mainDepartment.Add(WorkerFactory.GetWorker("HrManager","Менеджер по персоналу", "Оплата труда", "Имя")); break;
            //        default: mainDepartment.Add(WorkerFactory.GetWorker("Courier", "Курьер", "Оплата труда", "Имя")); break;
            //    }
            //}

            //mainDepartment.PeintRepository();

            //Console.WriteLine("\n---\n");

            #endregion


            Repository otherDepartment = RepositoryFactory.GetRepository(10);

            otherDepartment.Add(WorkerFactory.GetWorker("Teacher", "Учитель", "Оплата", "Имя"));

            otherDepartment.PeintRepository();
        }
    }
}