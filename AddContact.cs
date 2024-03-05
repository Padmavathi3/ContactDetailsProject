/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProject
{
    class AddressBook
    {
        public static List<AddressBook> listobj = new List<AddressBook>();
        public string Id { get; set; }    //Assigning the values
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }

        public void AddNewContact()              //creating new contact
        {
            AddressBook a = new AddressBook();      // create object to store the contact details
            Console.WriteLine("enter the Id:");
            a.Id = Console.ReadLine().ToLower();
            Console.WriteLine("enter the FirstName:");
            a.FirstName = Console.ReadLine().ToLower();
            Console.WriteLine("enter the Last name:");
            a.LastName = Console.ReadLine().ToLower();
            Console.WriteLine("enter the Address:");
            a.Address = Console.ReadLine().ToLower();
            Console.WriteLine("enter the City:");
            a.City = Console.ReadLine().ToLower();
            Console.WriteLine("enter the state:");
            a.State = Console.ReadLine().ToLower();
            Console.WriteLine("enter the Zipcode:");
            a.Zipcode = Console.ReadLine().ToLower();
            Console.WriteLine("enter the Mobilenumber:");
            a.MobileNumber = Console.ReadLine().ToLower();
            Console.WriteLine("enter the Email:");
            a.Email = Console.ReadLine().ToLower();

            listobj.Add(a);   // add storing details( in a) to list

            

        }
        public void DetailsOfContact()
        {
            if (listobj.Count > 0)
            {

                foreach (AddressBook a in listobj)
                {
                    Console.WriteLine("Person Id: " + a.Id);
                    Console.WriteLine("Person FirstName: " + a.FirstName);
                    Console.WriteLine("Person LastName: " + a.LastName);
                    Console.WriteLine("Person Address: " + a.Address);
                    Console.WriteLine("Person City: " + a.City);
                    Console.WriteLine("Person State: " + a.State);
                    Console.WriteLine("Person ZipCode: " + a.Zipcode);
                    Console.WriteLine("Person Mobilenumber: " + a.MobileNumber);
                    Console.WriteLine("Person Email: " + a.Email);
                    Console.WriteLine(" ");

                }
            }
            else
            {
                Console.WriteLine("List is Empty");
            }


        }
    } 
    class MainAddressBook
    {
        
        public static void Main(string[] args)
        {
            AddressBook obj = new AddressBook();
            obj.AddNewContact();
            obj.DetailsOfContact();
        }
    }
}
*/