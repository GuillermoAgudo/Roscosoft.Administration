using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Roscosoft.Administration.Contracts.ServiceLibrary.Contracts;
using Roscosoft.Administration.Contracts.ServiceLibrary.DTO;
using Roscosoft.Administration.WebUI.Models;
using System.Collections.Generic;

namespace Roscosoft.Administration.Controllers
{
    public class HomeController : Controller
    {
        private readonly INewService NewService;

        public HomeController(INewService newService)
        {
            this.NewService = newService;
        }

        public IActionResult Index()
        {
            var news = this.NewService.GetNews();
            var newModel = Mapper.Map<IEnumerable<NewDTO>, IEnumerable<NewModel>>(news);

            return View();
        }
    }
}
