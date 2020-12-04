using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookInCsharp
{
	class AddressBookMain
	{
		public static void Main(String[] args)
		{
			AddressBook addressBookServices = new AddressBook();
			Console.WriteLine("            Welcome to Address Book          ");
			Console.WriteLine("---------------------------------------------");
			addressBookServices.addContact();
			Console.WriteLine("Enter first name and last name of the person to remove the contact: ");
			String firstName = Console.ReadLine();
			String lastName = Console.ReadLine();
		}
	}
}

