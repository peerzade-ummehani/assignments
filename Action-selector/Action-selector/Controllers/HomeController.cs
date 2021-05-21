using System;
using System.Web.Mvc;


namespace Action_selector.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult index()
        {
            return View();
        }
        [ActionName("CurrentTime")]

        public string GetCurrentTime()
        {
            return "time is" + DateTime.Now.ToString("T");
        }

        //[NonAction]
        public string TimeString()
        {
            return "time is" + DateTime.Now.ToString("T");
        }
        [HttpGet]
        public string SetString()
        {
            return TimeString();
        }

        [ActionName("Access")]
        [HttpGet]
        public string GetAccess(String id)
        {
            return id;
        }


        [ActionName("Higher")]
        [HttpPost]
        public string GetHigher(String id)
        {
            return id;
        }
    }


}