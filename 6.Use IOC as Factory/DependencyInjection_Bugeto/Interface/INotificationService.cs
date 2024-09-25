using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection_Bugeto.Interface
{
    public interface INotificationService
    {
        void Send(string Message, long UserId);
    }
}
