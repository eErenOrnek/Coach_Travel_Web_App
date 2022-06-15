using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coach_Travel_Web_App.Controllers
{
    public class TransitExpressController : Controller
    {
        private readonly IDestinationService _destinationService;
        private readonly IBusService _busService;

        public TransitExpressController(IDestinationService destinationService, IBusService busService)
        {
            _destinationService = destinationService;
            _busService = busService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult FindResults(int cityFromId, int cityToId)
        {
            return View(_destinationService.GetDestinationsBySearch(cityFromId, cityToId));
        }

        public IActionResult Destinations()
        {
            return View(_destinationService.GetDestinationsWithCities());
        }

        public IActionResult BusHires()
        {
            return View(_busService.GetAll());
        }
    }
}
