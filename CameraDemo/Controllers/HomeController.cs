using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CameraDemo.Models;
using System.Web.Mvc;

namespace CameraDemo.Controllers
{
    public class HomeController : Controller
    {
     

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetQRCode(string qrCode)
        {
            QRCodeViewModel model = new QRCodeViewModel() { QRCodeInfo=qrCode};
            return View(model);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}