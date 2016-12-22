using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationModule
{
    public class Client
    {
        public const string ContactPhone = "phone";
        public const string ContactEmail = "email";
        public const string ContactVk = "vk";
        public const string ContactFacebook = "fb";

        public string Name { get; set; }
        public Dictionary<string, string> ContactData { get; set; }

        public Client(string name)
        {
            Name = name;
            ContactData = new Dictionary<string, string>();
        }

        public void AddContactData(string field, string value)
        {
            ContactData[field] = value;
        }
    }
}
