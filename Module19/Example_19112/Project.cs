using System;

namespace Example_19112
{
    class Project : IBuilder
    {
        private string name;

        public Project(string NameObj)
        {
            
            this.name = NameObj;
        }
        public void Build()
        {
            Console.WriteLine($"Строим {this.name}: Найди нужную сумму денег");
            Console.WriteLine($"Строим {this.name}: Закажи проект");
            Console.WriteLine($"Строим {this.name}: Найми рабочих");
            Console.WriteLine($"Строим {this.name}: Фундамент делается...");
            Console.WriteLine($"Строим {this.name}: Стены возводятся...");
            Console.WriteLine($"Строим {this.name}: Крыша кроется...");
            Console.WriteLine($"Строим {this.name}: Принять объект и указать, что требуется доделать");
            Console.WriteLine($"Строим {this.name}: Принять объект с доделками");
            Console.WriteLine();
        }
    }
}
