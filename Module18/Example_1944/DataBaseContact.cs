using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_1944
{
    class ContactBase: IEnumerable
    {
        public ContactBase()
        {
            storage = new List<Contact>();
        }
 
        public bool AddContact(Contact NewPeople)
        {
            bool check = false;
            if (!storage.Contains(NewPeople))
            {
                storage.Add(NewPeople);
                check = true;
            }

            return check;
        }

        public bool DeleteContact(Contact contact)
        {

            bool check = false;
            if (storage.IndexOf(contact) != -1)
            {
                storage.Remove(contact);
                check = true;
            }
            return check;
        }

        public int Count => storage.Count;

        public Contact this[int position]
        {
            get => !IsNull() ? storage[position] : null;
        }

        private bool IsNull()
        {
            bool check = true;

            if (storage != null)
            {
                if (storage.Count > 0)
                {
                    check = false;
                }
            }
            return check;
        }

        public IEnumerator GetEnumerator()
        {
            foreach (Contact c in storage)
            {
               yield return c;
            }
        }
  

        public List<Contact> Notebook
        {
            get => this.storage;
            set => this.storage = value;
        }

        private List<Contact> storage;

      
    }
}
