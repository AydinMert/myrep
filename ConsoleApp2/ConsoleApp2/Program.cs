using ConsoleApp2.Models;
using System;
using System.IO;
using System.Collections.Generic;

namespace ConsoleApp2
{
    internal class Program
    {
        static List<PersonModel> ids = new List<PersonModel>();
        static void Main(string[] args)
        {
            Console.WriteLine(" 1- Register \n 2- List Registrations \n 3- Update Registration \n 4- Delete Registration \n 5- Exit");

            int x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 1:
                    Register();
                    ShowMenu();
                    break;
                case 2:
                    List();
                    ShowMenu();
                    break;
                case 3:
                    Update();
                    ShowMenu();
                    break;
                case 4:
                    Delete();
                    ShowMenu();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
            }
        }

        public static void Register()
        {
            Console.WriteLine("Write your name: ");
            string name = Console.ReadLine();
            PersonModel person = new PersonModel();
            person.Name = name;
            Console.WriteLine("Write your phone number: ");
            person.PhoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Write your id: ");
            person.Id = Convert.ToInt32(Console.ReadLine());
            Search(person.Id);

            if (Search(person.Id) != null)
            {
                Console.WriteLine("This Id already exist.Please cahnge your id");
                Console.WriteLine("Write your id: ");
                person.Id = Convert.ToInt32(Console.ReadLine());
                ids.Add(person);
            }
            else
            {
                ids.Add(person);
            }
        }

        static void Update()
        {
            Console.WriteLine("Write your id:");
            int id = Convert.ToInt32(Console.ReadLine());
            PersonModel person = Search(id);
            Console.WriteLine("Write your new name: ");
            person.Name = Console.ReadLine();
            Console.WriteLine("Write your new phone number: ");
            person.PhoneNumber= Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Write your new id: ");
            person.Id = Convert.ToInt32(Console.ReadLine());
        }

        static void Delete()
        {
            Console.WriteLine("Write your id:");
            int id = Convert.ToInt32(Console.ReadLine());
            ids.Remove(Search(id));
        }

        public static PersonModel Search(int id)
        {
            int i = 0;
            foreach (var item in ids)
            {
                if (item.Id == id)
                {
                    return item;
                }
                i++;
            }
            return null;
        }

        static void List()
        {
            Console.WriteLine("  ID    |         Name          |     Phone Number    ");
            Console.WriteLine("-------------------------------------------------------");
            foreach (var item in ids)
            {
                
                Console.WriteLine("  " + Convert.ToString(item.Id) + "\t" + "|" + "\t" + item.Name + "\t" + "|" + "\t" + item.PhoneNumber + "\n");
            }
        }

        static void ShowMenu()
        {
            Console.WriteLine(" 1- Register \n 2- List Registrations \n 3- Update Registration \n 4- Delete Registration \n 5- Exit");

            int x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 1:
                    Register();
                    ShowMenu();
                    break;
                case 2:
                    List();
                    ShowMenu();
                    break;
                case 3:
                    Update();
                    ShowMenu();
                    break;
                case 4:
                    Delete();
                    ShowMenu();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}