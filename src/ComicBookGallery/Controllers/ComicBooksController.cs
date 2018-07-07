using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController: Controller
    {
        //adding an action method
        public ActionResult Detail()
        {

            if (DateTime.Today.DayOfWeek == DayOfWeek.Sunday)
            {
                return Redirect("/");


            }
            return Content("Hellp from the Comic books controller");
            
            

        }
    }
}
