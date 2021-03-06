using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AddressBook
{
    public class FileIOOperation
    {
        private string filePath = @"C:\Users\ITeS\Desktop\NEW ADDRESSBOOK\New-Address-Book\AddressBookDemo\CSVHandler.cs";
        public void WriteToFile(Dictionary<string, AddressBook> addressBookDictionary)
        {
            using StreamWriter writer = new StreamWriter(filePath, true);
            foreach (AddressBook addressBookobj in addressBookDictionary.Values)
            {
                foreach (Contact contact in addressBookobj.addressBook.Values)
                {
                    writer.WriteLine(contact.ToString());
                }
            }
            Console.WriteLine("\nSuccessfully added to Text file.");
            writer.Close();
        }
        public void ReadFromFile()
        {
            Console.WriteLine("Below are Contents of Text File");
            string lines = File.ReadAllText(filePath);
            Console.WriteLine(lines);
        }
    }
}