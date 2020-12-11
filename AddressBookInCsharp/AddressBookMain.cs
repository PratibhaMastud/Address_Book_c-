﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookInCsharp
{
    class AddressBookMain
    {
        AddressBook obj = new AddressBook();
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome in Address book System");
            Dictionary<string, AddressBook> abDict = new Dictionary<string, AddressBook>();
            bool ProgramIsRunning = true;

                Console.WriteLine("\nHow many address Book you want to create : ");
                int numAddressBooks = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= numAddressBooks; i++)
                {
                    Console.WriteLine("Enter the name of address book " + i + ": ");
                    string bookName = Console.ReadLine();
                    AddressBook addressBook = new AddressBook();
                    abDict.Add(bookName, addressBook);
                }
                Console.WriteLine("\nYou have created following Address Books : ");
                foreach (string k in abDict.Keys)
                {
                    Console.WriteLine(k);
                }
            while (ProgramIsRunning)
            {
                Console.WriteLine("\nChoose option to procced further \n1.Add Contact \n2.Edit Contact \n3.Delete Contact  \n4.Display Contacts \n5.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\nEnter Existing Address Book Name for adding contacts");
                        string contactName = Console.ReadLine();
                        if (abDict.ContainsKey(contactName))
                        {
                            Console.WriteLine("\nEnter the number of contacts you want to add in address book");
                            int numberOfContacts = Convert.ToInt32(Console.ReadLine());
                            for (int i = 1; i <= numberOfContacts; i++)
                            {
                                addContactBook(abDict[contactName]);
                            }
                            abDict[contactName].displayPerson();
                        }
                        else
                        {
                            Console.WriteLine("No AddressBook exist with name {0}", contactName);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter Address Book Name for edit contact");
                        string editcontactName = Console.ReadLine();
                        if (abDict.ContainsKey(editcontactName))
                        {
                            abDict[editcontactName].editPerson();
                            abDict[editcontactName].displayPerson();
                        }
                        else
                        {
                            Console.WriteLine("No Address book exist with name {0} ", editcontactName);
                        }
                        break;
                    case 3:
                        Console.WriteLine("\nEnter Address Book Name for delete contact");
                        string deleteContact = Console.ReadLine();
                        if (abDict.ContainsKey(deleteContact))
                        {
                            abDict[deleteContact].deletePerson();
                            abDict[deleteContact].displayPerson();
                        }
                        else
                        {
                            Console.WriteLine("No Address book exist with name {0} ", deleteContact);
                        }
                        break;
                    case 4:
                        Console.WriteLine("\nEnter Address Book Name for display contacts");
                        string displayContactsInAddressBook = Console.ReadLine();
                        abDict[displayContactsInAddressBook].displayPerson();
                        break;
                    case 5:
                        ProgramIsRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter valid option");
                        break;
                }
            }
            
            static void addContactBook(AddressBook addressBook)
            {
                    Console.WriteLine("Enter First Name : ");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("Enter Last Name : ");
                    string lastName = Console.ReadLine();
                    Console.WriteLine("Enter Address : ");
                    string address = Console.ReadLine();
                    Console.WriteLine("Enter City : ");
                    string city = Console.ReadLine();
                    Console.WriteLine("Enter State : ");
                    string state = Console.ReadLine();
                    Console.WriteLine("Enter Phone Number : ");
                    long phoneNumber = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("Enter Email id :");
                    string email = Console.ReadLine();
                    addressBook.AddContact(firstName, lastName, address, city, state, phoneNumber, email);
            }
        }
    }
}
 

