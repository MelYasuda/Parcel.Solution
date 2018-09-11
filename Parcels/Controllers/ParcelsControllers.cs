using Microsoft.AspNetCore.Mvc;
using Parcels.Models;
using System;

namespace Parcels.Controllers
{
    public class ParcelsController : Controller
    {
      [HttpGet("/parcel")]
      public ActionResult Index()
      {
        return View ();
      }

      [HttpGet("/parcel/new")]
      public ActionResult CreateForm()
      {
        return View ();
      }

      [HttpPost("/parcel")]
      public ActionResult Create()
      {

        Parcel newParcel = new Parcel(int.Parse(Request.Form["height"]), int.Parse(Request.Form["width"]), int.Parse(Request.Form["length"]), int.Parse(Request.Form["weight"]));

        return View ("Index", newParcel);
      }

    }
}
