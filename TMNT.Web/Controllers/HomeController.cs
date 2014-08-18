using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TMNT.Data;
using TMNT.Data.Models;
using TMNT.Web.Adapters;

namespace TMNT.Web.Controllers
{
    public class HomeController : Controller
    {
        private INinjaTurtles _adapter;
        public HomeController()
        {
            _adapter = new NinjaTurtlesAdapter();
        }
        public ActionResult Index()
        {
            return View(_adapter.GetAllTurtles());
        }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(string name, string picture, string weapon, string description)
        {
            _adapter.AddTurtle(name, picture, weapon, description);
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            return View(_adapter.GetTurtle(id));
        }
        public ActionResult Delete(int id)
        {
            _adapter.DeleteTurtle(id);
            return RedirectToAction("Index");
        }
        public ActionResult Update(int id)
        {
            return View(_adapter.GetTurtle(id));
        }
        [HttpPost]
        public ActionResult Update(int id, string name, string picture, string weapon, string description)
        {
            _adapter.UpdateTurtle(id, name, weapon, picture, description);
            return RedirectToAction("Details/" + id);
        }
    }
}