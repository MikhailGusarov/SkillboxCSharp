using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_1932
{
    public class BookWriter
    {

        public string Pages { get; set; }

        public BookWriter()
        {
        }

        private void AnyPages()
        {
            this.Pages = "Много страниц";
        }

        public void SaveDocx(string nameOfFile)
        {
            this.AnyPages();
            using (StreamWriter sw = new StreamWriter($"{nameOfFile}.docx"))
            {
                sw.WriteLine(Pages);
            }
        }

        public void SavePdf(string nameOfFile)
        {
            this.AnyPages();
            using (StreamWriter sw = new StreamWriter($"{nameOfFile}.pdf"))
            {
                sw.WriteLine(Pages);
            }
        }

        public void SaveXlsx(string nameOfFile)
        {
            this.AnyPages();
            using (StreamWriter sw = new StreamWriter($"{nameOfFile}.xlsx"))
            {
                sw.WriteLine(Pages);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BookWriter bookWriter = new BookWriter();
            bookWriter.SaveDocx("book");
            bookWriter.SavePdf("book");
            bookWriter.SaveXlsx("book");
        }
    }
}
