using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Syte.Models;

namespace Syte
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
            
        }

        public DbSet <Book> Book { get; set; }
        public DbSet <Category> Category { get; set; }
        public DbSet<Compilations> Compilation { get; set; }
        public DbSet<Publisher> Publisher { get; set; }
        public DbSet<Reviews> Reviews { get; set; }
        public DbSet<Authors> Authors { get; set; }
        public DbSet<Tags> Tags { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<MyBooks> MyBooks { get; set; }
    }
}
