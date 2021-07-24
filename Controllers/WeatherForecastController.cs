using RazorPdfTask.Models;
using Rotativa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class WeatherForecastController : Controller
    {
        // GET: WeatherForecast
        public ActionResult Index()
        {
            List<Weather> objweathers = new List<Weather>();

            for (int i = 0; i < 5; i++)
            {

                Weather weathers = new Weather();
                weathers.Date = DateTime.Now.AddDays(i);
                weathers.TemperatureC = 21 + i;
                weathers.TemperatureF = 32 + (int)(i / 0.5556);
                weathers.Summary = "Test Satyam";

                objweathers.Add(weathers);
            }
            return View(objweathers);
        }
        public ActionResult Convert()
        {
            var printpdf = new ActionAsPdf("Index");
            return printpdf;
        }
    }
}