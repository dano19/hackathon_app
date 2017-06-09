using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Hackathon_web.Controllers
{
    public class ListViewController : Controller
    {
        // GET: ListView
        public ActionResult Index()
        {
            

            return View();
        }

        public ActionResult HotelList() {

            List<Models.HotelItem> hotelList = new List<Models.HotelItem>
            {
                new Models.HotelItem() { Name = "Gotyk House", Address = "Barowa 4" },
                new Models.HotelItem() { Name = "Some House", Address = "Piwna 4", }

            };
            return View("HotelListView",hotelList);

        }
    }
}