using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMEfCodeFirst.Models
{
    public class SalesContext : DbContext //must connect to the dbcontext
    {

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }

        public SalesContext() : base() { } // calling base constructor with no parameters. make sure this one is on top.
        public SalesContext(DbContextOptions<SalesContext> options) : base(options) { }


        //methos to connect to 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connStr = "server=localhost\\sqlexpress;" + //connection string
                             "database=SalesFirst;" +
                             "trusted_connection=true;" +
                            "trustServerCertificate=true;";

            optionsBuilder.UseSqlServer(connStr); //use var connStr in parameters
        }
    }
}
