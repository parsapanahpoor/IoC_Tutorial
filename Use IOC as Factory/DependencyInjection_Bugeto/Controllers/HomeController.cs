using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DependencyInjection_Bugeto.Models;
using DependencyInjection_Bugeto.Interface;
using DependencyInjection_Bugeto.Services;

namespace DependencyInjection_Bugeto.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly  IEnumerable<INotificationService> _notificationService;
        private readonly IuploadServer _uploadToServer;

        private readonly IShareService _shareService;
        public HomeController(ILogger<HomeController> logger 
            , IuploadServer iuploadServer,
            IEnumerable<INotificationService> notificationService
            , IShareService shareService)
        {
            _logger = logger;
            _notificationService = notificationService;
            _uploadToServer = iuploadServer ;
            _shareService = shareService;
        }



        public IActionResult Share()
        {

            return Ok(_shareService.Execute());
        }

        public IActionResult Index()
        {
            foreach (var item in _notificationService)
            {
                item.Send("hi.......", 85845);
            }
            return View();
        }

        public IActionResult Upload()
        {
            _uploadToServer.Upload(null);
            return Ok(true);
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
