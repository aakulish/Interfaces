using NotificationModule.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationModule
{
    class NotificationManager
    {
        List<IService> _services = new List<IService>();

        public void AddService(IService service)
        {
            _services.Add(service);
        }
        
        public void ContactClient(Client client, string message)
        {
            foreach (var service in _services)
                if (service.CanUseService(client))
                    service.ContactClient(client, message);
        }
    }
}
