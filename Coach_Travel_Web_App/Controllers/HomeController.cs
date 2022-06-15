using BusinessLayer.Abstract;
using Coach_Travel_Web_App.Models;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Coach_Travel_Web_App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICityFromService _cityFromService;
        private readonly ICityToService _cityToService;

        public HomeController(ICityFromService cityFromService, ICityToService cityToService)
        {
            _cityFromService = cityFromService;
            _cityToService = cityToService;
        }

        public IActionResult Index()
        {
            CitiesModel citiesModel = new()
            {
                CitiesFrom = _cityFromService.GetAll(),
                CitiesTo = _cityToService.GetAll()
            };
            return View(citiesModel);
        }
    }
}
