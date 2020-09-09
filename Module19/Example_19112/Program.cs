using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_19112
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteBuilder.Build(new Project("Дом"));
            ConcreteBuilder.Build(new Project("Баня"));
            ConcreteBuilder.Build(new Project("Гараж"));
            ConcreteBuilder.Build(new Project("Паркинг"));
        }
    }
}
