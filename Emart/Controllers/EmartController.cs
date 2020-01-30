using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Emart.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Emart.Controllers
{
    public class EmartController : Controller
    {
        public readonly BuyerContext _context;
        public readonly SellerContext _context1;
        public EmartController(BuyerContext context, SellerContext context1)
        {
            this._context = context;
            this._context1 = context1;
        }
        //public EmartController(SellerContext context)
        //{
        //    this._context1 = context;
        //}
        // GET: Emart
        [HttpGet]
        public ActionResult BuyerRegistration()
        {

            return View();
        }
        [HttpPost]
        public ActionResult BuyerRegistration(Buyer b)
        {
            try
            {
                _context.Add(b);
                _context.SaveChanges();
                ViewBag.message = b.Bname + " has got successfully Registered";
                return RedirectToAction("BuyerLogin");

            }
            catch (Exception e)
            {
                ViewBag.message = b.Bname + " Registered failed";
                return View();
            }

        }
        [HttpGet]
        public ActionResult BuyerLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult BuyerLogin(Buyer b)
        {
            var logUser = _context.buyer.Where(e => e.Bname == b.Bname && e.Bpwd == b.Bpwd).ToList();
            if (logUser.Count == 0)
            {
                ViewBag.message = "Not valid user";
                return View();
            }
            else
            {
                HttpContext.Session.SetString("Bname", b.Bname);
                // HttpContext.Session.SetString("lastLogin", DateTime.Now.ToString());
                return RedirectToAction("CreateDashBoard");
            }

        }

        [HttpGet]
        public ActionResult SellerRegistration()
        {

            return View();
        }
        [HttpPost]
        public ActionResult SellerRegistration(Seller s)
        {
            try
            {
                _context1.Add(s);
                _context1.SaveChanges();
                ViewBag.message = s.Sname + " has got successfully Registered";
                return RedirectToAction("SellerLogin");

            }
            catch (Exception e)
            {
                ViewBag.message = s.Sname + " registered failed";
                return View();
            }

        }
        [HttpGet]
        public ActionResult SellerLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SellerLogin(Seller s)
        {
            var logUser = _context1.seller.Where(e => e.Sname == s.Sname && e.Spwd == s.Spwd).ToList();
            if (logUser.Count == 0)
            {
                ViewBag.message = "Not valid user";
                return View();
            }
            else
            {
                HttpContext.Session.SetString("Sname", s.Sname);
                // HttpContext.Session.SetString("lastLogin", DateTime.Now.ToString());
                return RedirectToAction("CreateDashBoard");
            }

        }





        //public ActionResult Index()
        //{
        //    return View();
        //}

        // GET: Emart/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Emart/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Emart/Create
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

        // GET: Emart/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Emart/Edit/5
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

        // GET: Emart/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Emart/Delete/5
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