using System;

namespace Agenda {

    public struct Contact {
        
        private string fullName;
        public TypeContact typeContact;
        public string phone;
        public string email;
        public string address;
        public string birthday;
        public string obs;

        public Contact(string fullName, TypeContact typeContact, string phone, string email, string address, string birthday, string obs){
            this.fullName = fullName;
            this.typeContact = typeContact;
            this.phone = phone;
            this.email = email;
            this.address = address;
            this.birthday = birthday;
            this.obs = obs;
        }

        public string FullName {
            get { return fullName; }
            set { fullName = value; }
        }

        public TypeContact TypeContact {
            get { return typeContact; }
            set { typeContact = value; }
        }

        public string Phone {
            get { return phone; }
            set { phone = value; }
        }

        public string Email {
            get { return email; }
            set { email = value; }
        }

        public string Address {
            get { return address; }
            set { address = value; }
        }

        public string Birthday {
            get { return birthday; }
            set { birthday = value; }
        }

        public string Obs {
            get { return obs; }
            set { obs = value; }
        }
    }
 
}