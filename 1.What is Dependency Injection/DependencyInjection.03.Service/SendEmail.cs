using DependencyInjection._03.Interface;
using System;

namespace DependencyInjection._03.Service
{
    public class SendEmail: ISendMessage
    {
        public void Send(string Email,string Name)
        {
            //----
            //---
            Console.WriteLine($"Email be {Name } ba addrese { Email}  ersal shod");
        }

    }
    
    
    public class SendNotif: ISendMessage
    {
        public void Send(string Email,string Name)
        {
            //----
            //---
            Console.WriteLine($"Notif be {Name } ba addrese { Email}  ersal shod");
        }

    }
}
