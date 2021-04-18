﻿using System;
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
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Authors> Authors { get; set; }
        //public IEnumerable<Tags> Tags { get; internal set; }
    }
}
