using NotificationModule.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationModule
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new Client("John Smith");
            client1.AddContactData(Client.ContactEmail, "jsmith@gmail.com");
            client1.AddContactData(Client.ContactPhone, "+1340123412");

            Client client2 = new Client("Andrew Mitchell");
            client2.AddContactData(Client.ContactEmail, "amitchell@yahoo.com");
            client2.AddContactData(Client.ContactFacebook, "123");

            NotificationManager manager = new NotificationManager();
            manager.AddService(new EmailService());
            manager.AddService(new SmsService());
            manager.AddService(new ViberService());
            manager.AddService(new WhatsAppService());
            manager.AddService(new FacebookService());

            manager.ContactClient(client1, "Hello!");
            manager.ContactClient(client2, "How are you?");

        }
    }
}
