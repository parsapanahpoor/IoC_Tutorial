using DependencyInjection_Bugeto.Interface;
using Microsoft.Extensions.Logging;

namespace DependencyInjection_Bugeto.Services
{
    public class SiteNotificationService : INotificationService
    {
       
        private readonly ILogger<SiteNotificationService> _logger;
        public SiteNotificationService(ILogger<SiteNotificationService> logger)
        {
            _logger = logger;
        }
        public void Send(string Message, long UserId)
        {
            //
            _logger.LogInformation($"site notif {Message} sended for user :{UserId}");
        }
    }
}
