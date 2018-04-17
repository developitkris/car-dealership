using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Dealership.Models;

namespace Dealership.Controllers
{
    public class CarController : Controller
    {

        [HttpGet("/cars")]
        public ActionResult Index()
        {
            List<Car> allCars = Car.GetAll();
            return View(allCars);
        }

        [HttpGet("/cars/new")]
        public ActionResult CreateForm()
        {
            return View();
        }
        [HttpPost("/cars")]
        public ActionResult Create()
        {
          Car userCar = new Car (Request.Form["new-item"]);
          userCar.Save();
          List<Car> allCars = Car.GetAll();
          return View("Index", allCars);
        }
        //
        // [HttpPost("/cars/delete")]
        // public ActionResult DeleteAll()
        // {
        //     Car.ClearAll();
        //     return View();
        // }
    }
}
