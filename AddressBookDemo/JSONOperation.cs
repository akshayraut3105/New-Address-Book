using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AddressBook
{
    public class JSONOperation
    {
        string filePath = @"C:\Users\ITeS\Desktop\NEW ADDRESSBOOK\New-Address-Book\AddressBookDemo\Utility\ABRecord.json";
        public void WriteToFile(Dictionary<string, AddressBook> addressBookDictionary)
        {
            string json = "";
            foreach (AddressBook obj in addressBookDictionary.Values)
            {
                foreach (Contact contact in obj.addressBook.Values)
                {
                    json = JsonConvert.SerializeObject(contact);
                    File.WriteAllText(filePath, json);
                }
            }
            Console.WriteLine("\nSuccessfully added to JSON file.");
        }
        public void ReadFromFile()
        {
            Console.WriteLine("Below are Contents of JSON File");
            var json = File.ReadAllText(filePath);
            Contact contact = JsonConvert.DeserializeObject<Contact>(json);
            Console.WriteLine(contact.ToString());
        }
    }
}