using System;
using System.Linq;

namespace Agenda
{

    class Program
    {
        // static List<Contact> shedule = new List<Contact>();
        static Contact [] shedule = new Contact [100];
        static int top = 0;

        public static void AddContact()
        {
            Contact c = new Contact();

            Console.WriteLine("Digite seu nome completo");
            Console.Write("Digite seu primeiro nome ");
            string firstName = Console.ReadLine();
            
            Console.Write("Digite seu sobrenome ");
            string lastName = Console.ReadLine();

            c.FullName = firstName + " " + lastName;
            
            Console.WriteLine("Escolha seu tipo de contato");
            Console.WriteLine("Escolha entre: 1 - Celular, 2 - Trabalho, 3 - Casa, 4 - Principal, 5 - Pager");
            Console.WriteLine("Escolha entre: 6 - Fax Trabalho, 7 - Fax Casa, 8 - Outros");
            c.TypeContact =  (TypeContact) int.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu telefone DDD+Numero");
            string DDD = Console.ReadLine();
            string phoneNumber = Console.ReadLine();

            c.Phone = DDD+phoneNumber;

            Console.WriteLine("Digite seu telefone Email");
            c.Email = Console.ReadLine();

            Console.WriteLine("Digite seu endereço (bairro,cidade,estado)");
            Console.Write("Digite seu bairro ");
            string district = Console.ReadLine();
            Console.Write("Digite sua cidade ");
            string city = Console.ReadLine();
            Console.Write("Digite seu estado ");
            string state = Console.ReadLine();
            c.Address = district + "," + city + "," + state;

            Console.WriteLine("Digite sua de Nascimento");
            Console.Write("Digite o dia ");
            String day = Console.ReadLine();
            Console.Write("Digite o mês ");
            String month = Console.ReadLine();
            Console.Write("Digite o ano ");
            String year = Console.ReadLine();
            c.Birthday = day + "/" + month + "/" + year;

            Console.WriteLine("Digite alguma informação adicional");
            c.Obs = Console.ReadLine();

            if (top < 100){
                shedule[top] = c;
                top = top + 1;
            }
        }

        public static void Search(string searchName){

            for(int i = 0; i < shedule.Length; i++){

                if(shedule[i].FullName != null) {
                    string [] firstName = shedule[i].FullName.Split(' ');
                    if(firstName[0].Contains(searchName)){
                        Console.WriteLine($"======={i}======");
                        Console.WriteLine(shedule[i].FullName);
                        Console.WriteLine($"contato {shedule[i].TypeContact}");
                        Console.WriteLine($"telefone - {shedule[i].Phone}, email - {shedule[i].Email}");
                        Console.WriteLine(DayForYourBirthday(i));
                        Console.WriteLine("===============");
                    }
                }
            }

        }

        public static void SearchTypeContact(TypeContact searchTypeContact){

            for(int i = 0; i < shedule.Length; i++){
                if(shedule[i].TypeContact.Equals(searchTypeContact)){
                    Console.WriteLine($"======={i}======");
                    Console.WriteLine(shedule[i].FullName);
                    Console.WriteLine($"contato {shedule[i].TypeContact}");
                    Console.WriteLine($"telefone - {shedule[i].Phone}, email - {shedule[i].Email}");
                    Console.WriteLine(DayForYourBirthday(i));
                    Console.WriteLine("===============");
                }
            }
        }

        public static void SearchCity(string searchCity){
            for(int i = 0; i < shedule.Length; i++){
                if(shedule[i].Address != null) {
                    string [] city = shedule[i].Address.Split(',');
                    if(city[1].Equals(searchCity)){
                        Console.WriteLine($"======={i}======");
                        Console.WriteLine(shedule[i].FullName);
                        Console.WriteLine($"contato {shedule[i].TypeContact}");
                        Console.WriteLine($"telefone - {shedule[i].Phone}, email - {shedule[i].Email}");
                        Console.WriteLine(DayForYourBirthday(i));
                        Console.WriteLine("===============");
                    }
                }
            }

        }

        public static string DayForYourBirthday(int position) {
            
            DateTime currentDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
            
            string [] birthday = shedule[position].Birthday.Split('/');
            DateTime dateBirthday = new DateTime(DateTime.Today.Year,int.Parse(birthday[1]),int.Parse(birthday[0]));

            if (currentDate == dateBirthday) {
                return "É seu Aniversário";
            } else if (currentDate > dateBirthday) {
                return "Você já teve seu aniversário";
            } else {
                return $"Faltam {dateBirthday.Subtract(DateTime.Today).TotalDays}";
            }
        }

        public static void DeleteContact(string name){
            for (int i = 0; i < shedule.Length; i++){
                if(shedule[i].FullName != null) {
                    string [] firstName = shedule[i].FullName.Split(' ');
                    if(firstName[0].Contains(name)){
                        shedule = shedule.Where((e, contact) => contact != i).ToArray();
                    }
                }
            }
        }
        
        static void Main(string[] args)
        {
        
            bool flag = true;
            while(flag) {

                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Adicionar contato.");
                Console.WriteLine("2 - Buscar por nome.");
                Console.WriteLine("3 - Buscar por nome completo.");
                Console.WriteLine("4 - Buscar por tipo de contato");
                Console.WriteLine("5 - Buscar pela cidade");
                Console.WriteLine("6 - remover contato.");
                Console.WriteLine("7 - Sair.");
                
                int option = int.Parse(Console.ReadLine());

                switch(option) {

                    case 1:
                        AddContact();
                        break;

                    case 2:
                        Console.WriteLine("Buscar por nome Completo");
                        string searchFullName = Console.ReadLine();
                        Search(searchFullName);
                        break;

                    case 3:
                        Console.WriteLine("Buscar por nome");
                        string searchName = Console.ReadLine();
                        Search(searchName);
                        break;

                    case 4:
                        Console.WriteLine("Buscar por tipo de contato");
                        Console.WriteLine("Escolha entre: 1 - Celular, 2 - Trabalho, 3 - Casa, 4 - Principal, 5 - Pager");
                        Console.WriteLine("Escolha entre: 6 - Fax Trabalho, 7 - Fax Casa, 8 - Outros");
                        TypeContact searchTypeContact =  (TypeContact) int.Parse(Console.ReadLine());
                        SearchTypeContact(searchTypeContact);
                        break;

                    case 5:
                        Console.WriteLine("Buscar por Cidade");
                        string searchCity = Console.ReadLine();
                        Search(searchCity);
                        break;

                    case 6:
                        Console.WriteLine("Digite o nome do contato que quer deletar.");
                        string deleteName = Console.ReadLine();
                        DeleteContact(deleteName);
                        break;

                    case 7:
                        flag = false;
                        break;
                }

            }

        }
    }
}

