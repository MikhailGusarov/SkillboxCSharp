namespace Example_1931
{






    public class BookWriter
    {
        public IBookSave Mode { get; set; }

         
        public string Pages { get; set; }

        public BookWriter(IBookSave Method)
        {
            this.Mode = Method;
        }

        private void AnyPages()
        {
            this.Pages = "Много страниц";
        }

        public void Save()
        {
            this.AnyPages();
            Mode.SaveBookPages(Pages);
        }
    }
}
