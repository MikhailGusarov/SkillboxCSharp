using System.IO;

namespace Example_1931
{
    class KeeperDocx :  IBookSave
    {
        private string nameOfFile;
        public KeeperDocx(string NameOfFile)
        {
            this.nameOfFile = NameOfFile;
        }

        private string CreateDocx(string Pages)
        {
            return Pages;
        }

        public void SaveBookPages(string Pages)
        {
            using (StreamWriter sw = new StreamWriter($"{nameOfFile}.docx"))
            {
                sw.WriteLine(CreateDocx(Pages));
            }
        }
    }
}
