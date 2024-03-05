using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AddressBook
{
   /*class AddressBook
    {
        public static List<AddressBook> listobj = new List<AddressBook>();
        public string Id { set; get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }

        

        public void AddContact()
        {
            AddressBook a = new AddressBook();  // create object to store the contact details
            string id_pattern = "^[0-9]{3}$";
            string fname_pattern = "^[A-Z]{1}[a-z]{2,}";
            string lname_pattern = "^[A-Z]{1}[a-z]{2,}$";
            string add_pattern = "^[0-9]{1,2}-[0-9]{1,2},[A-Z]{1}[a-z]{5,},[A-Z]{1}[a-z]{3,}$";
            string city_pattern = "^[A-Z]{1}[a-z]{3,}";
            string state_pattern = "^[A-Z]{1}[a-z]{3,}$";
            string zip_pattern = "^[1-9]{1}[0-9]{5}$";
            string mn_pattern = "^[6-9]{1}[0-9]{9}$";
            string email_pattern = "^[a-z \\- \\.]*@[a-z]*.com$";

            while(true)
            {
                Console.WriteLine("enter the Id:");
                a.Id = Console.ReadLine();
                if ((Regex.IsMatch(a.Id, id_pattern))==true)
                {
                    Console.WriteLine("Your input is matched so you can go for another field");
                    break;
                }
                else
                {
                    Console.WriteLine("Your input is not matched so try again");
                }
            } 
            while (true)
            {
                Console.WriteLine("enter the FirstName:");
                a.FirstName = Console.ReadLine();
                if ((Regex.IsMatch(a.FirstName, fname_pattern))==true)
                {
                    Console.WriteLine("Your input is matched so you caan go for another field");
                    break;
                }
                else
                {
                    Console.WriteLine("Your input is not matched so try again");
                }
            }
            while (true)
            {
                Console.WriteLine("enter the Last name:");
                a.LastName = Console.ReadLine();
                if ((Regex.IsMatch(a.LastName, lname_pattern)) == true)
                {
                    Console.WriteLine("Your input is matched so you caan go for another field");
                    break;
                }
                else
                {
                    Console.WriteLine("Your input is not matched so try again");
                }
            }
            int c = 0;
            if (listobj.Count > 0)
            {
                foreach (AddressBook b in listobj)
                {
                    if ((b.FirstName.Equals(a.FirstName)) && (b.FirstName.Equals(a.FirstName)))
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
                while (true)
                {
                    Console.WriteLine("enter the Address:");
                    a.Address = Console.ReadLine();
                    if ((Regex.IsMatch(a.Address, add_pattern)) == true)
                    {
                        Console.WriteLine("Your input is matched so you caan go for another field");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Your input is not matched so try again");
                    }
                }
                while (true)
                {
                    Console.WriteLine("enter the City:");
                    a.City = Console.ReadLine();
                    if ((Regex.IsMatch(a.City, city_pattern)) == true)
                    {
                        Console.WriteLine("Your input is matched so you caan go for another field");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Your input is not matched so try again");
                    }
                }
                while (true)
                {
                    Console.WriteLine("enter the state:");
                    a.State = Console.ReadLine();
                    if ((Regex.IsMatch(a.State, state_pattern)) == true)
                    {
                        Console.WriteLine("Your input is matched so you can go for another field");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Your input is not matched so try again");
                    }
                }
                while (true)
                {
                    Console.WriteLine("enter the Zipcode:");
                    a.Zipcode = Console.ReadLine();
                    if ((Regex.IsMatch(a.Zipcode, zip_pattern)) == true)
                    {
                        Console.WriteLine("Your input is matched so you caan go for another field");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Your input is not matched so try again");
                    }
                }
                while (true)
                {
                    Console.WriteLine("enter the Mobilenumber:");
                    a.MobileNumber = Console.ReadLine();
                    if ((Regex.IsMatch(a.MobileNumber, mn_pattern)) == true)
                    {
                        Console.WriteLine("Your input is matched so you caan go for another field");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Your input is not matched so try again");
                    }
                }
                while (true)
                {
                    Console.WriteLine("enter the Email:");
                    a.Email = Console.ReadLine();
                    if ((Regex.IsMatch(a.Email, email_pattern)) == true)
                    {
                        Console.WriteLine("Your input is matched so you caan go for another field");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Your input is not matched so try again");
                    }
                }
                listobj.Add(a);
            }
           


            Console.WriteLine("Do you want to check another option");
            string op = Console.ReadLine();
            if (op.ToLower() == "yes")
            {
                MainAddressBook.Main(new string[] { });
            }
        }

        public void EditContact()
        {
            Console.WriteLine("enter the firstname to edit the details:");
            string Fname = Convert.ToString(Console.ReadLine()).ToLower();
            Console.WriteLine("enter the lastname to edit the details:");
            string Lname = Convert.ToString(Console.ReadLine()).ToLower();
            Console.WriteLine("enter the updated field");
            string field=Console.ReadLine();
            Console.WriteLine("enter updated field");
            var value=Console.ReadLine();
            if(listobj.Count > 0) 
            {
                foreach(AddressBook b in listobj) 
                {
                    if ((b.FirstName.Equals(Fname)) && (b.LastName.Equals(Lname)))
                    {
                        switch (field)
                        {
                            case "Id":
                                b.Id = value;
                                break;
                            case "Firstname":
                                b.FirstName=value;
                                break;
                            case "LastName":
                                b.LastName = value;
                                break;
                            case "Address":
                                b.Address = value;
                                break;
                            case "State":
                                b.State = value;
                                break;
                            case "City":
                                b.City = value;
                                break;
                            case "ZipCode":
                                b.Zipcode = value;
                                break;
                            case "MobileNumber":
                                b.MobileNumber = value;
                                break;
                            case "Email":
                                b.Email = value;
                                break;
                            default:
                                Console.WriteLine("invalid field");
                                break;

                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("list is empty");
            }
            Console.WriteLine("Do you want to check another option");
            string op = Console.ReadLine();
            if (op.ToLower() == "yes")
            {
                MainAddressBook.Main(new string[] { });
            }
        }

        public void DeleteContact()
        {
            Console.WriteLine("enter the fname to dalete the details:");
            string Fname1 = Console.ReadLine().ToLower();
            Console.WriteLine("enter the lastname to edit the details:");
            string Lname1 = Console.ReadLine().ToLower();
            AddressBook ab = null;
            if (listobj.Count > 0)
            {
                foreach (AddressBook b in listobj)
                {
                    if ((b.FirstName.Equals(Fname1)) && (b.LastName.Equals(Lname1)))
                    {
                        ab = b;
                    }
                    else
                    {
                        Console.WriteLine("deleting is not possible because fname and lname are not match");
                    }

                }
                if (ab != null)
                {
                    int index = listobj.IndexOf(ab);// Getting the index value of the object
                    listobj.RemoveAt(index);
                    Console.WriteLine("deletion done successfully");

                }
            }
            else
            {
                Console.WriteLine("list is Empty");
            }

                    Console.WriteLine("do u want to check another option");
                    string op = Console.ReadLine();
                    if (op.ToLower() == "yes")
                    {
                        MainAddressBook.Main(new string[] { });
                    }
                
            
        }
        
        public void DetailsOfContact()
        {
            if (listobj.Count > 0) 
            {
                foreach(AddressBook b in listobj)
                {
                    Console.WriteLine("Person Id: " + b.Id);
                    Console.WriteLine("Person FirstName: " + b.FirstName);
                    Console.WriteLine("Person LastName: " + b.LastName);
                    Console.WriteLine("Person Address: " + b.Address);
                    Console.WriteLine("Person City: " + b.City);
                    Console.WriteLine("Person State: " + b.State);
                    Console.WriteLine("Person ZipCode: " + b.Zipcode);
                    Console.WriteLine("Person Mobilenumber: " + b.MobileNumber);
                    Console.WriteLine("Person Email: " + b.Email);
                    Console.WriteLine(" ");
                }
            }
            else
            {
                Console.WriteLine("list is empty");
            }

            Console.WriteLine("do u want to check another option");
            string op = Console.ReadLine();
            if (op.ToLower() == "yes")
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
            Console.WriteLine("1.Add new contact \n2.Edit the existing contact details \n3.Delete the existing contact\n4.To see the existing details");
            Console.WriteLine("enter the option number:");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    obj.AddContact();
                    break;
                case 2:
                    obj.EditContact();
                    break;
                case 3:
                    obj.DeleteContact();
                    break;
                case 4:
                    obj.DetailsOfContact();
                    break;
                default:
                    Console.WriteLine("Invalid number");
                    break;
            }
        }
    } */
    
}
