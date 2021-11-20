using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Template.Models;

namespace Template.Controllers
{
    public class TourController : Controller
    {
        // GET: Tour
        public ActionResult Index()
        {
            BucketListMVCEntities entities = new BucketListMVCEntities();
            
            return View(entities.Details_Table.ToList());
        }
    }
}