using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppNomina.Controllers
{
    public class accesoController : Controller
    {
        // GET: acceso
        public ActionResult Index()
        {
            return View();
        }

        // GET: acceso/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: acceso/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: acceso/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: acceso/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: acceso/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: acceso/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: acceso/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
