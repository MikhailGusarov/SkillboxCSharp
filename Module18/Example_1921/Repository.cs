using System;
using System.Collections.Generic;
using System.Linq;

namespace Example_1921
{
    class Repository
    {
        List<IWorker> db;

        public Repository()
        {
            db = new List<IWorker>();
        }

        public Repository(IEnumerable<IWorker> Args)
        {
            db = Args.ToList<IWorker>();
        }

        public void Add(IWorker Worker)
        {
            db.Add(Worker);
        }

        public void PeintRepository()
        {
            foreach (var e in db)
            {
                Console.WriteLine(e.ToString());
            }
        }

    }
}
