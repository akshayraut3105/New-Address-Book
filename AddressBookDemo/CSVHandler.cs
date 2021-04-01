using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace AddressBook
{
    public class CSVHandler : CSVHandlerBase
    {
        private string filePath = @"C:\Users\ITeS\Desktop\NEW ADDRESSBOOK\New-Address-Book\AddressBookDemo\CSVHandler.cs";

        public void ReadFromFile()
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                using (CsvReader csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    Console.WriteLine("Below are Contents of CSV File");
                    List<Contact> contactRecord = csv.GetRecords<Contact>().ToList();
                    foreach (Contact contact in contactRecord)
                    {
                        Console.WriteLine(contact.ToString());
                    }
                }
            }

        }
    }
}