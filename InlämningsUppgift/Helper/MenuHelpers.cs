using InlämningsUppgift.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlämningsUppgift.Helper
{


        internal static class MenuHelper
        {
            public static List<KontaktPerson> kontaktPerson = new List<KontaktPerson>();
            public static void ViewKontaktPersonList(List<KontaktPerson> list)
            {
                Console.Clear();
                Console.WriteLine("###### VIEW KontaktPerson LIST ######");
                foreach (var kontaktPerson in list)
                {
                    Console.WriteLine($"{kontaktPerson.Id}. {kontaktPerson.FirstName} {kontaktPerson.LastName} ({kontaktPerson.Email})");
                }
                Console.ReadKey();

            }
            public static KontaktPerson CreateNewCustomer()
            {
                Console.Clear();
                Console.WriteLine("###### CREATE NEW CUSTOMER ######");

                var kontaktPerson = new KontaktPerson();
                Console.Write("First Name: "); kontaktPerson.FirstName = Console.ReadLine();
                Console.Write("Last Name:  "); kontaktPerson.LastName = Console.ReadLine();
                Console.Write("Email:  "); kontaktPerson.Email = Console.ReadLine();

                return kontaktPerson;
            }    //KontaktPerson
                 //kontaktPerson
            public static void RemoveCustomer(ref List<KontaktPerson> list)

            {
                Console.Clear();
                Console.WriteLine("###### REMOVE KONTAKT PERSON ######");
                Console.WriteLine("KontaktPerson Id: ");
                var kontaktPersonId = Console.ReadLine();

                list = list.Where(x => x.Id != int.Parse(kontaktPersonId)).ToList();
            }

            public static void MainMenu()

            {
                Console.Clear();
                Console.WriteLine("###### MENU ######");
                Console.WriteLine("1. View Kontakt Person List");
                Console.WriteLine("2. Create new Kontakt Person");
                Console.WriteLine("3. Remove Kontakt Person");
                Console.Write("Choose one option: ");


                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        ViewKontaktPersonList(kontaktPerson);
                        break;

                    case "2":
                        kontaktPerson.Add(CreateNewCustomer());
                        break;

                    case "3":
                        RemoveCustomer(ref kontaktPerson);
                        break;
                }
            }
        }

    
}

