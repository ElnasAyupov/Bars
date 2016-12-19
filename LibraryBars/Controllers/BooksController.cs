using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LibraryBars.Models;
using Microsoft.AspNet.Identity;
using LibraryBars.Constants;
namespace LibraryBars.Controllers
{
    [Authorize(Roles = "Customer, Librarian")]
    public class BooksController : Controller
    {
        private LibraryContext db = new LibraryContext();

        // GET: Books
        
        public ActionResult Index(string sort, string search)
        {
            
            ViewBag.NameSort = String.IsNullOrEmpty(sort) ? "name_desc" : "";
            ViewBag.CreatorSort = sort == "Creator" ? "creator_desc" : "Creator";
            ViewBag.YearSort = sort == "Year" ? "year_desc" : "Year";

            var books = from s in db.Books select s;

            if (!String.IsNullOrEmpty(search)) { books = books.Where(s => s.Name.ToUpper().Contains(search.ToUpper()) || s.Creator.ToUpper().Contains(search.ToUpper())); }

            switch (sort)
            {
                case "name_desc":
                    books = books.OrderByDescending(s => s.Name);
                    break;
                case "Creator":
                    books = books.OrderBy(s => s.Creator);
                    break;
                case "creator_desc":
                    books = books.OrderByDescending(s => s.Creator);
                    break;
                case "year_desc":
                    books = books.OrderByDescending(s => s.Year);
                    break;
                case "Year":
                    books = books.OrderBy(s => s.Year);
                    break;
                default:
                    books = books.OrderBy(s => s.Name);
                    break;
            }

            if (User.IsInRole("Customer"))
            {
                return View(books.Where(s => s.Count > 0).ToList());
            }
            else
            {
                return View(books.ToList());
            }

        }
        public ActionResult TakenBooks()
        {
            //var TakenBooksId = db.Orders.GroupBy(t => t.BookId).Select(k => new
            //{
            //    BookId = k.Key,
            //    Count = k.Count()
            //}).ToList();
            var TakenBooksId = db.Orders.Where(t => t.Status == Statuses.InProgress);
            List<Book> books = new List<Book>();
            foreach (var a in TakenBooksId)
            {
                books.Add(db.Books.Where(t => t.BookId == a.BookId).FirstOrDefault());
            }
            return View(books);
        }
        public ActionResult UserBooks()
        {
            var CurrentUserId = User.Identity.GetUserId();
            var CurrentCustomerId = db.Customers.Where(t => t.SecCode == CurrentUserId).FirstOrDefault();
            if (CurrentCustomerId == null)
            {
                return Redirect("/Customers/Create");
            }
            else
            {
                var Orders = db.Orders.Where(t => t.CustomerId == CurrentCustomerId.CustomerId && t.Status == Statuses.InProgress);
                List<Book> books = new List<Book>();
                foreach (var a in Orders)
                {
                    books.Add(db.Books.Where(t => t.BookId == a.BookId).FirstOrDefault());
                }
                //var BooksInOrders = Orders.Join(db.Books, Order => Order.Book, Book => Book, (Order, Book) => new { BookId = Book.BookId, Name = Book.Name});
                return View(books);
            }
        }

        // GET: Books/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = db.Books.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }
        public ActionResult ReturnBook(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = db.Books.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            var UserId = User.Identity.GetUserId();
            var QueryUserResult = db.Customers.Where(t => t.SecCode == UserId).FirstOrDefault();
            var CurrentUserId = QueryUserResult.CustomerId;
            var QueryOrderResult = db.Orders.Where(t => t.BookId == id && t.CustomerId == CurrentUserId && t.Status == Statuses.InProgress).FirstOrDefault();

            db.Books.Find(id).Count += 1;
            db.Orders.Find(QueryOrderResult.OrderId).Status = Statuses.Returned;
            db.SaveChanges();

            return Redirect("/Books/UserBooks");
        }
        [Authorize(Roles = "Customer")]
        public ActionResult TakeBook(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = db.Books.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }

            var UserId = User.Identity.GetUserId();
            var Result = db.Customers.Where(t => t.SecCode == UserId).FirstOrDefault();
            if (Result == null)
            {
                return Redirect("/Customers/Create");
            }
            var Check = db.Orders.Where(t => t.BookId == id && t.CustomerId == Result.CustomerId && t.Status == Statuses.InProgress).FirstOrDefault();
            if (Check!=null)
            {
                return Redirect("/Books/UserBooks");
            }
            if (Result!=null)
            {
                var CurrentId = Result.CustomerId;
                Customer customer = db.Customers.Find(CurrentId);
                Order order = new Order();
                db.Books.Find(id).Count -= 1;
                db.SaveChanges();
                order.BookId = book.BookId;
                order.CustomerId = customer.CustomerId;
                order.DateFrom = DateTime.Now;
                order.DateTo = DateTime.Now.AddMonths(1);
                OrdersController OC = new OrdersController();
                OC.Create(order);
                return Redirect("/Books/UserBooks");
            }
            else
            {
                return Redirect("/Customers/Create");
            }
            
        }

        // GET: Books/Create
        [Authorize(Roles = "Librarian")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Books/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Librarian")]
        public ActionResult Create([Bind(Include = "BookId,Name,Year,Creator,Genre,Count")] Book book)
        {
            if (ModelState.IsValid)
            {
                db.Books.Add(book);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(book);
        }

        // GET: Books/Edit/5
        [Authorize(Roles = "Librarian")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = db.Books.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        // POST: Books/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Librarian")]
        public ActionResult Edit([Bind(Include = "BookId,Name,Year,Creator,Genre,Count")] Book book)
        {
            if (ModelState.IsValid)
            {
                db.Entry(book).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(book);
        }

        // GET: Books/Delete/5
        [Authorize(Roles = "Librarian")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = db.Books.Find(id);
            var result = db.Orders.Where(t => t.BookId == id).FirstOrDefault();
            if (result !=null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        // POST: Books/Delete/5
        [Authorize(Roles = "Librarian")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Book book = db.Books.Find(id);
            db.Books.Remove(book);
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
