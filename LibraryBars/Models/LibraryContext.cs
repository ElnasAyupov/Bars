using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using LibraryBars.Constants;

namespace LibraryBars.Models
{
    public class LibraryInitializer : System.Data.Entity.
        DropCreateDatabaseAlways<LibraryContext>
    {
        protected override void Seed(LibraryContext context)
        {
            context.Books.Add(new Book {Name = "Война и мир", Year = "1880", Creator = "Толстой", Genre = Genres.Romance, Count = 3 });
            context.Books.Add(new Book { Name = "Моби дик", Year = "1700", Creator = "Неизвестный", Genre = Genres.Fantasy, Count = 5 });
            context.Books.Add(new Book { Name = "Книжка", Year = "1932", Creator = "Писатель", Genre = Genres.Autobiography, Count = 0 });

            base.Seed(context);
        }
    }
    public class LibraryContext : DbContext
    {
        public LibraryContext() : base ("LibraryDB")
        {

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
