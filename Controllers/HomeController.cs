using System;
using Parcel.Models;
using Microsoft.AspNetCore.Mvc;

namespace Parcel.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult HomePage() { return View();}

    [Route("/parcel-form")]
    public ActionResult ParcelForm() { return View();}

    [Route("/parcel")]
    public ActionResult Parcel(int length, int width, int height, int weight)
    { 
      if (length <= 0 || width <= 0 || height <= 0 || weight <= 0)
      {
        return View("index");
      }
      else
      {
      ParcelCalc myParcelCalc = new ParcelCalc();
      Console.WriteLine(length);
      myParcelCalc.BoxLength = length;
      myParcelCalc.BoxWidth = width;
      myParcelCalc.BoxHeight = height;
      myParcelCalc.BoxWeight = weight;
      return View(myParcelCalc);
      }
    }
  }
}