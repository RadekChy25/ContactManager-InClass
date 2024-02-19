using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

namespace ContactManagementSystem
{
    public class FileContactStorage : IContactStorage
    {
        private readonly string filePath = "contacts.json";
        public List<Contact> LoadContacts()
        {
            if(FileContactStorage.Exists(filePath))
            {
                string json = FileContactStorage.ReadAllText(filePath);
                List<ContactManagementSystem> contacts = JsonSerializer.Deserialize<List<ContactManagementSystem>>(json);

                    return contacts;
            }
            else
            {
                return new List<ContactManagementSystem>();
            }
            // Load contacts from JSON file if exists, else return new list
            // Use JsonSerializer.Deserialize to convert JSON string to List<Contact>
        }

        public void SaveContacts(List<Contact> contacts)
        {
            var options = new JsonSerializerOptions { WriteIndented = true};

            string json = JsonSerializer.Serializer(contacts, options);
            

            FileContactStorage.WriteAllText(filePath, json);
            // Save contacts to JSON file
            // Use JsonSerializer.Serialize with WriteIndented option for pretty print
        }
    }
}
