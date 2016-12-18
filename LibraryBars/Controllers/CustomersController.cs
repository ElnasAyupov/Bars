using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LibraryBars.Models;
using LibraryBars.Controllers;
using Microsoft.AspNet.Identity;

namespace LibraryBars.Controllers
{
    public class CustomersController : Controller
    {
        private LibraryContext db = new LibraryContext();

        // GET: Customers
        public ActionResult Index()
        {
            return View(db.Customers.ToList());
        }
        public ActionResult Timeovered()
        {
            var Orders = db.Orders.Where(t => t.Status == Constants.Statuses.InProgress).GroupBy(t => t.CustomerId);
            List<Customer> customers = new List<Customer>();
            foreach (var a in Orders)
            {
                customers.Add(db.Customers.Where(t => t.CustomerId == a.Key).FirstOrDefault());
            }
            return View(customers);
        }

        // GET: Customers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // GET: Customers/Create
        public ActionResult Create()
        {
            string user = User.Identity.GetUserId();
            var result = db.Customers.Where(t => (t.SecCode == user));
            if (result.Any())
            {
                int Customer=0;
                foreach (var a in result)
                {
                    Customer = a.CustomerId;
                }
                return RedirectToAction("Details", new { id = Customer });
            }
            else
            {
                return View();
            }
                
        }

        // POST: Customers/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CustomerId,Name,Address,Phone,SecCode")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                if (customer.SecCode == User.Identity.GetUserId())
                {
                    return RedirectToAction("Details", new { id = customer.CustomerId });
                }
                else
                {
                    customer.SecCode = User.Identity.GetUserId();
                    db.Customers.Add(customer);
                    db.SaveChanges();
                    return RedirectToAction("Details", new { id = customer.CustomerId });
                }
            }
            return View(customer);
        }

        // GET: Customers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // POST: Customers/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CustomerId,Name,Address,Phone, SecCode")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Details", new { id = customer.CustomerId });
            }
            return View(customer);
        }

        // GET: Customers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Customer customer = db.Customers.Find(id);
            db.Customers.Remove(customer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
