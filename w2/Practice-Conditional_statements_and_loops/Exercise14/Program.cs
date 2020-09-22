using System;
using System.Security.Cryptography.X509Certificates;

namespace Exercise14
{
    class Program
    {
        /*
         14.A given company has name, address, phone number, fax number, web site and manager.
         The manager has name, surname and phone number. 
         Write a program that reads information about the company and its manager and then prints
         it on the console.

         */
        static void Main(string[] args)
        {
            Console.WriteLine("Enter company details:");
            Console.WriteLine("Company name");
            string companyName = Console.ReadLine();
            Console.WriteLine("Company address");
            string address = Console.ReadLine();
            Console.WriteLine("Company phone number");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Company fax number");
            string faxNumber = Console.ReadLine();
            Console.WriteLine("Company website");
            string webSite = Console.ReadLine();
            Console.WriteLine("Company manager");
            string manager = Console.ReadLine();
            Console.WriteLine("Company manager firt name");
            string managerFirstName = Console.ReadLine();
            Console.WriteLine("Company manager last name");
            string managerLastName = Console.ReadLine();
            Console.WriteLine("Company manager phone number");
            string managerPhoneNumber = Console.ReadLine();

            CompanyDetails(companyName,address,phoneNumber,faxNumber,webSite,manager,
                managerFirstName,managerLastName,managerPhoneNumber);
            
            Console.ReadLine();

            static void CompanyDetails(
                string companyName,
                string address,
                string phoneNumber,
                string faxNumber,
                string webSite,
                string manager,
                string managerFirstName,
                string managerLastName,
                string managerPhoneNumber)
            {
                Console.WriteLine(companyName + "\n" + address + "\n" + phoneNumber + "\n" + faxNumber + "\n" +
                    webSite + "\n" + "\n" + manager + "\n" + managerFirstName + "\n" + managerLastName + "\n" +
                    managerPhoneNumber);
            }

        }
    }
}
