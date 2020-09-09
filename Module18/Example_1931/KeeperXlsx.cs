using System.IO;

namespace Example_1931
{
    class KeeperXlsx :  IBookSave
    {
        private string nameOfFile;

        public KeeperXlsx(string NameOfFile)
        {
            this.nameOfFile = NameOfFile;
        }
        private string CreateXlsx(string Pages)
        {
            return Pages;
        }
        public void SaveBookPages(string Pages)
        {
            using (StreamWriter sw = new StreamWriter($"{nameOfFile}.xlsx"))
            {
                sw.WriteLine(CreateXlsx(Pages));
            }
        }
    }
}
