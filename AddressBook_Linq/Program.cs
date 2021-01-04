using System;

namespace AddressBook_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************Welcome To AddressBook Linq************");
            AddressModel model = new AddressModel();
            AddressBook_DataTable dataTable = new AddressBook_DataTable();
            dataTable.CreateTable();
            while (true)
            {
                Console.WriteLine("Enter Choice \n1.Display \n2.Add Contact \n 3.Edit Contact  \n4.Exit ");
                int choise = Convert.ToInt32(Console.ReadLine());
                try
                {
                    switch (choise)
                    {
                        case 1:
                            dataTable.Display();
                            break;
                        case 2:
                            Console.Write("Enter the first name: ");
                            model.firstName = Console.ReadLine();
                            Console.Write("Enter the last name :");
                            model.lastName = Console.ReadLine();
                            Console.Write("Enter the city : ");
                            model.city = Console.ReadLine();
                            Console.Write("Enter the state :");
                            model.state = Console.ReadLine();
                            Console.Write("Enter the zip code : ");
                            model.zip = Console.ReadLine();
                            Console.Write("Enter the phone number : ");
                            model.phoneNumber = Console.ReadLine();
                            dataTable.AddContact(model);
                            break;
                        case 3:
                            Console.Write("Enter the first name: ");
                            model.firstName = Console.ReadLine();
                            Console.Write("Enter the last name :");
                            model.lastName = Console.ReadLine();
                            Console.Write("Enter the city : ");
                            model.city = Console.ReadLine();
                            Console.Write("Enter the state :");
                            model.state = Console.ReadLine();
                            Console.Write("Enter the zip code : ");
                            model.zip = Console.ReadLine();
                            Console.Write("Enter the phone number : ");
                            model.phoneNumber = Console.ReadLine();
                            dataTable.EditContact(model);
                            break;
                        case 4:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Enter The Valid Choise");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("please enter integer options only");
                }
            }
        }
    }
}
