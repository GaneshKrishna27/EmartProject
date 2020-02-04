using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Emart.Controllers
{
    public class SellerBuyerController : Controller
    {
        // GET: SellerBuyer
        public ActionResult Index()
        {
            return View();
        }

        // GET: SellerBuyer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SellerBuyer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SellerBuyer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SellerBuyer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SellerBuyer/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SellerBuyer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SellerBuyer/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}