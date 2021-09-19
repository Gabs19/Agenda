using System;
using System.Collections.Generic;

namespace Agenda
{
    class Program
    {
        static void Main(string[] args)
        {
        
            List<Contact> shedule = new List<Contact>();
            // string [] shedule = new string [100];

            bool flag = true;
            while(flag) {

                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Adicionar contato.");
                Console.WriteLine("2 - Buscar por nome.");
                Console.WriteLine("3 - Buscar por nome completo.");
                Console.WriteLine("4 - Sair.");
                
                int option = int.Parse(Console.ReadLine());

                switch(option) {

                    case 1:
                        Contact c = new Contact();
                        Console.WriteLine("Digite seu primeiro nome");
                        string firstName = Console.ReadLine();
                        
                        Console.WriteLine("Digite seu sobrenome");
                        string lastName = Console.ReadLine();
                        
                        c.FullName = firstName + lastName;
                        shedule.Add(c);

                        break;

                    case 2:
                        break;

                    case 3:
                        string searchName = Console.ReadLine();

                        foreach(Contact i in shedule) {

                            if(i.FullName.Contains(searchName)){

                                Console.WriteLine(i.FullName);

                            } else { 

                                Console.WriteLine("Erro 404"); 
                                
                                }
                        }
                        break;

                    case 4:
                        flag = false;
                        break;
                }


                // Console.WriteLine("Deseja adicinar um novo contato? caso deseje apenas digite 'sim'");
                // string aswer = Console.ReadLine();

                // if (aswer == "sim") {
                    
                    
                    // Console.WriteLine("Escolha seu contato");
                    // stypeContact = Console.ReadLine();

                    // Console.WriteLine("Digite seu Telefone");
                    // string DDD = Console.ReadLine();
                    // phone[0] = DDD;
                    
                    // string number = Console.ReadLine();
                    // phone[1] = number;

                    // for(int i = 0; i < shedule.Length; i++) {
                    //     if (shedule[i] != null){
                    //         shedule[i] = 
                    //     }
            }

            foreach(Contact contact in shedule){
                Console.WriteLine(contact.FullName);
            }
        }
    }
}

