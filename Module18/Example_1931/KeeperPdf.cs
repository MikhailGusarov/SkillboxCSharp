using System.IO;

namespace Example_1931
{
    class KeeperPdf : IBookSave
    {
        private string nameOfFile;
        public KeeperPdf(string NameOfFile)
        {
            this.nameOfFile = NameOfFile;
        }

        private string CreatePdf(string Data)
        {
            return Data;
        }

        public void SaveBookPages(string Pages)
        {
            using (StreamWriter sw = new StreamWriter($"{nameOfFile}.pdf"))
            {
                sw.WriteLine(CreatePdf(Pages));
            }
        }
    }
}
