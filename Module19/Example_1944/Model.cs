using System;
using System.Diagnostics;
using System.IO;

namespace Example_1944
{
    class Model
    {
        public Model(string path)
        {
            currentContactBase = new ContactBase();
            index = 0;
            this.path = path;
        }

        public Contact CurrentContact
        {
            get
            {
                if (Index >= 0) { return currentContactBase[index]; }
                else { return null; }
            }
        }

        public void LoadContacts()
        {
            try
            {
                string[] allData = File.ReadAllLines(this.path);

                for (int i = 0; i < allData.Length; i += 2)
                {
                    this.currentContactBase.AddContact(new Contact(allData[i], allData[i + 1]));
                }
            }
            catch (Exception)
            {
                Debug.WriteLine($"Файл {this.path} не обнаружен");
            }
        }

        public void SaveContactBase()
        {
            if (File.Exists(this.path)) File.Delete(this.path);

            foreach (Contact e in currentContactBase)
            {
                File.AppendAllText(this.path, $"{e.TelephoneNumbere}\n");
                File.AppendAllText(this.path, $"{e.ContactName}\n");
            }
        }

        public ContactBase CurrentContactBase => this.currentContactBase;

        public int Index
        {
            get => this.index;
            set => this.index = value;
        }

        ContactBase currentContactBase;
        private int index;
        private string path;

    }
}
