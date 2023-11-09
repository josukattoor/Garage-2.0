using Garage_2._0.Data;
using Garage_2._0.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Garage_2._0.Controllers
{
    public class RecieptController : Controller
    {
        // GET: RecieptController

        private readonly Garage_2_0Context _context;
        public RecieptController(Garage_2_0Context context)
        {
            _context = context;
        }

        public ActionResult DisplayReciept()
        {
            ViewBag.Message = "Enter the Registration number of the vehicle to print the receipt:";
            return View();
            //var customer = _context.Vehicle.Find(VehicleId);
            //return View(customer);
        }
        public IActionResult PrintableForm(RemoveVehicleViewModel model)
        {
            if (ModelState.IsValid)
            {

                var vehicle = _context.Vehicle.FirstOrDefault(v => v.RegNumber == model.RegNumber);

                if (vehicle != null)
                {

                    return View("PrintableForm", vehicle);
                }
                else
                {

                    TempData["ErrorMessage"] = "The registration number does not exist in the database.";

                    // return RedirectToAction("Remove");
                }
            }

            return View("PrintableForm", model);
        }
        public ActionResult Index()
        {
            return View();
        }

        // GET: RecieptController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RecieptController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RecieptController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RecieptController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RecieptController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RecieptController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RecieptController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
