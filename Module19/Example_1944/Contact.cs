using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_1944
{
    class Contact : IEquatable<Contact>
    {
        public bool Equals(Contact other)
        {
            return this.contactTelephoneNumbere == other.contactTelephoneNumbere
                   && this.contactName == other.ContactName;
        }
        public Contact(string TelephoneNumbere, string ContactName)
        {
            this.contactName = ContactName;
            this.contactTelephoneNumbere = TelephoneNumbere;
        }

        public string ContactName
        {
            get => this.contactName;
            set => this.contactName = value;
        }

        public string TelephoneNumbere
        {
            get => this.contactTelephoneNumbere;
            set => this.contactTelephoneNumbere = value;
        }

        private string contactName;
        private string contactTelephoneNumbere;

    }
}
