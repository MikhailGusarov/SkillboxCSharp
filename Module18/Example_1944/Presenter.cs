using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Example_1944
{
    class Presenter
    {
        private Model model;
        private IView view;

        public Presenter(IView View)
        {
            this.view = View;
            model = new Model("contacts.txt");
        }

        public void LoadContacts()
        {
            model.LoadContacts();

            if (model.CurrentContactBase.Count > 0)
            {
                model.Index = 0;
                var temp = model.CurrentContact;

                view.ContactTelephoneNumber = temp.TelephoneNumbere;
                view.ContactName = temp.ContactName;
            }
        }

        public void AddContact()
        {
            model.CurrentContactBase.AddContact(
                new Contact(view.ContactTelephoneNumber, view.ContactName)
                );
        }

        public void RemoveContact()
        {
            Contact t = new Contact(view.ContactTelephoneNumber, view.ContactName);
            model.CurrentContactBase.DeleteContact(t);

            if (model.CurrentContactBase.Count < 1)
            {
                model.Index = -1;

                view.ContactTelephoneNumber = string.Empty;
                view.ContactName = string.Empty;
            }
            else
            {
                model.Index--;
                if (model.Index < 0) model.Index = 0;

                view.ContactTelephoneNumber = model.CurrentContact.TelephoneNumbere;
                view.ContactName = model.CurrentContact.ContactName;
            }
        }

        public void SaveContactBase()
        {
            model.SaveContactBase();
        }

        public void NextContact()
        {
            if(model.CurrentContactBase.Count > 0)
            {
                if(model.Index + 1 < model.CurrentContactBase.Count)
                {
                    model.Index++;
                    view.ContactTelephoneNumber = model.CurrentContact.TelephoneNumbere;
                    view.ContactName = model.CurrentContact.ContactName;
                }
            }
        }

        public void PrevContact()
        {
            if (model.CurrentContactBase.Count > 0)
            {
                if (model.Index - 1 > -1)
                {
                    model.Index--;
                    view.ContactTelephoneNumber = model.CurrentContact.TelephoneNumbere;
                    view.ContactName = model.CurrentContact.ContactName;
                }
            }
        }
    }
}