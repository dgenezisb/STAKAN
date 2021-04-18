using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Syte.Models;

namespace Syte
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {

        }

        public DbSet <Book> Book { get; set; }
        public DbSet<Tags> Tags { get; set; }
        public DbSet<Category> Category { get; set; }

    }
}
