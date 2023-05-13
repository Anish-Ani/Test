using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Demo.Models;

namespace Demo.Controllers
{
    public class valuesController : Controller
    {
        private Database1Entities db = new Database1Entities();

        // GET: values
        public ActionResult Index()
        {
            return View();
        }

        public List<value> getvalue()
        {
            List<value> values = new List<value>();
            values = db.values.ToList();
            return values;
        }
        [HttpPost]
        public String Addvalue(String value)
        {
            String uid = Guid.NewGuid().ToString("N");
           int values= int.Parse(value);
            Random rnd = new Random();
            int id = rnd.Next(4, 2000);
            value val = new value();
            val.Id = id;
            val.value1 = values;
            db.values.Add(val);
            db.SaveChanges();
            return "Sucess";
        }





        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,value1")] value value)
        {
            if (ModelState.IsValid)
            {
                db.values.Add(value);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(value);
        }
    }
}
