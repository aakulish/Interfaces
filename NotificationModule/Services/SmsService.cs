using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationModule.Services
{
    class SmsService : IService
    {
        public void ContactClient(Client client, string message)
        {
            Console.WriteLine("'{0}' sent to {1} via Sms", message, client.Name);
        }

        public bool CanUseService(Client client)
        {
            return client.ContactData.ContainsKey(Client.ContactPhone);
        }
    }
}
