using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_1931
{


    class Program
    {
        static void Main(string[] args)
        {
            var saveToXlsx = new KeeperXlsx("KeeperXlsx");
            var saveToPdf = new KeeperPdf("KeeperPdf");
            var saveToDocx = new KeeperDocx("KeeperDocx");

            BookWriter bw = new BookWriter(saveToXlsx);

            bw.Save();
            Console.ReadKey();


            bw.Mode = saveToPdf;
            bw.Save();
            Console.ReadKey();


            bw.Mode = saveToDocx;
            bw.Save();

            Console.ReadKey();

        }
    }
}
