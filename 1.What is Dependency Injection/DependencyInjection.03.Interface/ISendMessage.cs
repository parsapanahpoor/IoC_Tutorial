using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection._03.Interface
{
    public interface ISendMessage
    {
        void Send(string Email,string Name);
    }
}
