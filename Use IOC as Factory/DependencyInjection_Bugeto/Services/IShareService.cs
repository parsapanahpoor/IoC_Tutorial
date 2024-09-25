using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection_Bugeto.Services
{
    public interface IShareService
    {
        string Execute();
    }

    public class TelegramShare : IShareService
    {
        public string Execute()
        {
            return "در تلگرام به اشتراک گذاشته شد";
        }
    } 
    
    public class InstagramShare : IShareService
    {
        public string Execute()
        {
            return "در اینستا به اشتراک گذاشته شد.";
        }
    }
}
