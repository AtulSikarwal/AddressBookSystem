using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class AddressBook
    {

        public static List<Contacts> Info = new List<Contacts>();
        public void AddPerson()
        {
            Contacts Person = new Contacts();

            Console.WriteLine("Enter the First Name :");
            Person.FirstName = Console.ReadLine();

            Console.WriteLine("Enter the Last Name :");
            Person.LastName = Console.ReadLine();


            Console.WriteLine("Enter the City Name :");
            Person.City = Console.ReadLine();


            Console.WriteLine("Enter the Zip Code :");
            Person.Zip = Console.ReadLine();



            Console.WriteLine("Enter the Email id :");
            Person.Email = Console.ReadLine();


            Console.WriteLine("Enter the Address :");
            Person.Address = Console.ReadLine();

            Info.Add(Person);

        }


        


      
    }
}
