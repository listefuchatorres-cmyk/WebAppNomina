using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppNomina.Models
{
    public class DepartamentController : Controller
    {
        // GET: Departament
        public ActionResult Index()
        {
            return View();
        }

        // GET: Departament/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Departament/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Departament/Create
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

        // GET: Departament/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Departament/Edit/5
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

        // GET: Departament/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Departament/Delete/5
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
