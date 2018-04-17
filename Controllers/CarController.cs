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
            return View("DisplayCars", allCars);
        }

        [HttpGet("/cars/new")]
        public ActionResult CreateForm()
        {
            return View("Index");
        }
        [HttpPost("/cars")]
        public ActionResult Create()
        {
          Car userCar = new Car (Request.Form["brand"], Request.Form["model"],int.Parse(Request.Form["mileage"]), int.Parse(Request.Form["price"]));
          userCar.Save();
          List<Car> allCars = Car.GetAll();
          // return View("DisplayCars", allCars);
          return RedirectToAction("Index");
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
