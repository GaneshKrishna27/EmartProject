using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Emart.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;

namespace Emart.Controllers
{
    public class EmartController : Controller
    {
        public readonly BuyerContext _context;
        public readonly SellerContext _context1;
        private readonly IWebHostEnvironment hostingEnvironment;
        public EmartController(BuyerContext context, SellerContext context1, IWebHostEnvironment hostingEnvironment)
        {
            this._context = context;
            this._context1 = context1;
            this.hostingEnvironment = hostingEnvironment;
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
                return RedirectToAction("_Layout");
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
                return RedirectToAction("_Layout");
            }

        }

        public IActionResult SellerBuyer()
        {
            return View();
        }

        //**********************************************

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Seller/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SellerCreate model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;

                // If the Photo property on the incoming model object is not null, then the user
                // has selected an image to upload.
                if (model.Photopath != null)
                {
                    // The image must be uploaded to the images folder in wwwroot
                    // To get the path of the wwwroot folder we are using the inject
                    // HostingEnvironment service provided by ASP.NET Core
                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "Images");
                    // To make sure the file name is unique we are appending a new
                    // GUID value and and an underscore to the file name
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Photopath.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    // Use CopyTo() method provided by IFormFile interface to
                    // copy the file to wwwroot/images folder
                    model.Photopath.CopyTo(new FileStream(filePath, FileMode.Create));
                }
                Seller newseller = new Seller

                {
                    Sname = model.Sname,
                   
                    Spwd = model.Spwd,
                    Companyname = model.Companyname,
                    Email = model.Email,
                    Gstin = model.Gstin,
                    Bank_Details = model.Bank_Details,
                    Postal_Address = model.Postal_Address,
                    Mobile = model.Mobile,


                    // Store the file name in PhotoPath property of the employee object
                    // which gets saved to the Employees database table
                    Photopath = uniqueFileName
                };
                _context.Add(newseller);
                _context.SaveChanges();
                return RedirectToAction("Details", new {Sid = newseller.Sid });
            }
            else
                return View();
        }

        public ActionResult Details(int Sid)
        {
            Seller seller1 = _context1.seller.FirstOrDefault(m => m.Sid == Sid);
            return View(seller1);
        }


        //public ActionResult Index()
        //{
        //    return View();
        //}

        // GET: Emart/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}


        // GET: Emart/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        // POST: Emart/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

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