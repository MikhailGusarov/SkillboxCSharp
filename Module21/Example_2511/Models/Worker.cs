using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example_2511.Models
{
    //Анемичная модель
    public class Worker
    {
        public int Age { get; set; }
        public int Salary { get; set; } 
        public string Name { get; set; }
    }

    #region _

    ////Полная модель
    //public class Worker
    //{
    //    public int Age { get; set; }
    //    public int Salary { get; set; }
    //    public string Name { get; set; }
    //
    //    public Worker(string Name, int Age, int Salary)
    //    {
    //        this.Name = Name;
    //        this.Age = Age;
    //        this.Salary = Salary;
    //    }
    //
    //    public override string ToString()
    //    {
    //        return $"Имя: {this.Name} \nВозраст: {this.Age} \nОплата труда ${this.Salary}";
    //    }
    //}

    #endregion
}
