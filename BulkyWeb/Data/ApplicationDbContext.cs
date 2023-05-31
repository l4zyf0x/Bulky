using BulkyWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyWeb.Data
{
    public class ApplicationDbContext : DbContext // this DbContext will requre ConnectionString
    {
        // while configuring ApplicationDbContext, we will get the connection string as a parameter 
        // in constructor as DbContextOptions and 
        // we will pass that to the base class (DbContext)
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        // create a table
        // Category table 
        // table name : Categories
        public DbSet<Category> Categories { get; set; }
    }
}
