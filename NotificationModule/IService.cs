using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationModule
{
    interface IService
    {
        bool CanUseService(Client client);
        void ContactClient(Client client, string message);
    }
}
