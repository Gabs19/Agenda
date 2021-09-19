using System;

namespace Agenda {

    public struct Contact {
        
        private string fullName;
        // public string typeContact;
        // public string phone;
        // public string email;
        // public string address;
        // public string birthday;
        // public string obs;


        public Contact(String fullName) {
            this.fullName = fullName;
        }

        // public Contact(string fullName, string typeContact, string phone, string email, string address, string birthday, string obs){
        //     this.fullName = fullName;
        //     this.typeContact = typeContact;
        //     this.phone = phone;
        //     this.email = email;
        //     this.address = address;
        //     this.birthday = birthday;
        //     this.obs = obs;
        // }

        public string FullName {
            get { return fullName; }
            set { fullName = value; }
        }


    }
 
}