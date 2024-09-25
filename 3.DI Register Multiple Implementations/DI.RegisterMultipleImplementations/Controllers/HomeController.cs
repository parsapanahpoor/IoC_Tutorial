using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DI.RegisterMultipleImplementations.Models;
using DI.RegisterMultipleImplementations.Interface;
using DI.RegisterMultipleImplementations.Models.DIClass;
using Microsoft.Extensions.Options;

namespace DI.RegisterMultipleImplementations.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MailSetting _mailSetting;
        //private readonly ISendEmailService _sendEmailService;
        private readonly IEnumerable<ISendEmailService> _sendEmailServicesList;
        public HomeController(ILogger<HomeController> logger/*, ISendEmailService sendEmailService*/
            , IEnumerable<ISendEmailService> sendEmailServices
            ,IOptions<MailSetting> options)
        {
            _logger = logger;
            //_sendEmailService = sendEmailService;
            _sendEmailServicesList = sendEmailServices;
            _mailSetting = options.Value;
        }

        public IActionResult Index()
        {

            //ViewBag.message= _sendEmailService.Send();
            ViewBag.message= _sendEmailServicesList.FirstOrDefault(p=> p.GetType().Name ==_mailSetting.Sender).Send();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
