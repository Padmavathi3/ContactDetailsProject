using System;
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
            int c = 0;
            if (listobj.Count > 0)
            {
                foreach (AddressBook b in listobj)
                {
                    if ((b.FirstName.Equals(a.FirstName)) && (b.LastName.Equals(a.LastName)))
                    {
                        c = c + 1;
                    }
                }
            }

            if (c > 0)
            {
                Console.WriteLine("The name already exist");
            }
            else
            {


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

                listobj.Add(a);
            }

            

            Console.WriteLine("do you want check another option:");
            string op = Console.ReadLine();
            if (op.ToLower() == "yes")
            {
                MainAddressBook.Main(new string[] { });


            }

        }
        public void EditExistingContact()
        {
            Console.WriteLine("enter the firstname to edit the details:");
            string Fname = Convert.ToString(Console.ReadLine()).ToLower();
            Console.WriteLine("enter the lastname to edit the details:");
            string Lname = Convert.ToString(Console.ReadLine()).ToLower();
            AddressBook ab = null;
            foreach (AddressBook a in listobj)
            {
                if ((a.FirstName.Equals(Fname)) && (a.LastName.Equals(Lname)))
                {
                    ab = a;
                }
                else
                {
                    Console.WriteLine("Editing is not possible because fname and lname are not match");
                }
            }
            if (ab != null)
            {

                Console.WriteLine("press \n 1 for update FirstName  \n 2 for update LastName  \n 3 for update Address  \n 4 for update City\n 5 for update State  \n 6 for update ZipCode \n 7 for update MobileNumber  \n 8 for update Email");
                int index = listobj.IndexOf(ab);// Getting the index value of the object
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the value to be updated");
                        listobj[index].FirstName = Console.ReadLine().ToLower();//getting the object based on the index and updating the value
                        break;
                    case 2:
                        Console.WriteLine("Enter the value to be updated");
                        listobj[index].LastName = Console.ReadLine().ToLower();
                        break;
                    case 3:
                        Console.WriteLine("Enter the value to be updated");
                        listobj[index].Address = Console.ReadLine().ToLower();
                        break;
                    case 4:
                        Console.WriteLine("Enter the value to be updated");
                        listobj[index].City = Console.ReadLine().ToLower();
                        break;
                    case 5:
                        Console.WriteLine("Enter the value to be updated");
                        listobj[index].State = Console.ReadLine().ToLower();
                        break;
                    case 6:
                        Console.WriteLine("Enter the value to be updated");
                        listobj[index].Zipcode = Console.ReadLine().ToLower();
                        break;
                    case 7:
                        Console.WriteLine("Enter the value to be updated");
                        listobj[index].MobileNumber = Console.ReadLine().ToLower();
                        break;
                    case 8:
                        Console.WriteLine("Enter the value to be updated");
                        listobj[index].Email = Console.ReadLine().ToLower();
                        break;
                    default:
                        Console.WriteLine("invalid Number");
                        break;
                }
                Console.WriteLine("updation done successfully");

            }

            Console.WriteLine("do you want check another option:");
            string op1 = Console.ReadLine();
            if (op1.ToLower() == "yes")
            {
                MainAddressBook.Main(new string[] { });


            }
        }
        public void DeleteExistingContact()
        {
            Console.WriteLine("enter the fname to dalete the details:");
            string Fname1 = Console.ReadLine().ToLower();
            Console.WriteLine("enter the lastname to edit the details:");
            AddressBook ab1 = null;

            string Lname1 = Console.ReadLine().ToLower();
            foreach (AddressBook a in listobj)
            {
                if ((a.FirstName.Equals(Fname1)) && (a.LastName.Equals(Lname1)))
                {
                    ab1 = a;
                }
                else
                {
                    Console.WriteLine("deleting is not possible because fname and lname are not match");
                }
            }
            if (ab1 != null)
            {
                int index = listobj.IndexOf(ab1);// Getting the index value of the object
                listobj.RemoveAt(index);
                Console.WriteLine("deletion done successfully");

            }

            Console.WriteLine("do you want check another option:");
            string op1 = Console.ReadLine();
            if (op1.ToLower() == "yes")
            {
                MainAddressBook.Main(new string[] { });


            }

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
            Console.WriteLine("do you want check another option:");
            string op1 = Console.ReadLine();
            if (op1.ToLower() == "yes")
            {
                MainAddressBook.Main(new string[] { });


            }
        }


    }

    class MainAddressBook
    {
        
        public static void Main(string[] args)
        {
            AddressBook obj = new AddressBook();
            Console.WriteLine("choose any one option");
            Console.WriteLine("1.Add new contact \n2.Edit the existing contact details \n3.Delete the existing contact\n4.To see the existing details of contacts");
            Console.WriteLine("enter the option number:");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    obj.AddNewContact();
                    break;
                case 2:
                    obj.EditExistingContact();
                    break;
                case 3:
                    obj.DeleteExistingContact();
                    break;
                case 4:
                    obj.DetailsOfContact();
                    break;
                default:
                    Console.WriteLine("Invalid number");
                    break;
            }
        }
    }

}


