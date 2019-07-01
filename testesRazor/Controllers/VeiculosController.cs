using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using testesRazor.Models;

namespace testesRazor.Controllers
{
    public class VeiculosController : Controller
    {
        // GET: Veiculos
        public ActionResult Index()
        {
            var listOfVehicles = new List<VeiculosModel>();
            listOfVehicles.Add(new VeiculosModel(1, "teste", 2));

            listOfVehicles.Add(new VeiculosModel(2, "teste2", 2));

            listOfVehicles.Add(new VeiculosModel(3, "teste3", 2));

            listOfVehicles.Add(new VeiculosModel(4, "teste4", 2));
            listOfVehicles.Add(new VeiculosModel(5, "teste", 2));

            listOfVehicles.Add(new VeiculosModel(6, "teste2", 2));

            listOfVehicles.Add(new VeiculosModel(7, "teste3", 2));

            listOfVehicles.Add(new VeiculosModel(8, "teste4", 2));
            listOfVehicles.Add(new VeiculosModel(9, "teste", 2));

            listOfVehicles.Add(new VeiculosModel(10, "teste2", 2));

            listOfVehicles.Add(new VeiculosModel(11, "teste3", 2));

            listOfVehicles.Add(new VeiculosModel(12, "teste4", 2));
            listOfVehicles.Add(new VeiculosModel(13, "teste", 2));

            listOfVehicles.Add(new VeiculosModel(14, "teste2", 2));

            listOfVehicles.Add(new VeiculosModel(15, "teste3", 2));

            listOfVehicles.Add(new VeiculosModel(16, "teste4", 2));
            listOfVehicles.Add(new VeiculosModel(17, "teste", 2));

            listOfVehicles.Add(new VeiculosModel(18, "teste2", 2));

            listOfVehicles.Add(new VeiculosModel(19, "teste3", 2));

            listOfVehicles.Add(new VeiculosModel(20, "teste4", 2));
            listOfVehicles.Add(new VeiculosModel(21, "teste", 2));

            listOfVehicles.Add(new VeiculosModel(22, "teste2", 2));

            listOfVehicles.Add(new VeiculosModel(23, "teste3", 2));

            listOfVehicles.Add(new VeiculosModel(24, "teste4", 2));
            listOfVehicles.Add(new VeiculosModel(25, "teste", 2));

            listOfVehicles.Add(new VeiculosModel(26, "teste2", 2));

            listOfVehicles.Add(new VeiculosModel(27, "teste3", 2));

            return View(listOfVehicles);
        }

        // GET: Veiculos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Veiculos/Create
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

        // GET: Veiculos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Veiculos/Edit/5
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

   
        // POST: Veiculos/Delete/5
        [HttpPost]
        public JsonResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return Json(new { response = "deletado" + id });
            }
            catch
            {
                return Json(new { response = "deletado" + id });
            }
        }
    }
}
