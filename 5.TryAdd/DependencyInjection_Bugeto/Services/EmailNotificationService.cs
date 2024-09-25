using DependencyInjection_Bugeto.Interface;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection_Bugeto.Services
{
    public class EmailNotificationService : INotificationService
    {
       
        private readonly ILogger<EmailNotificationService> _logger;
        public EmailNotificationService(ILogger<EmailNotificationService> logger)
        {
            _logger = logger;
        }
        public void Send(string Message, long UserId)
        {
            //
            _logger.LogInformation($"Email {Message} sended for user :{UserId}");
        }
    }   
}
