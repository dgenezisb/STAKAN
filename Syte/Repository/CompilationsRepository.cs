﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Syte.Interfaces;
using Syte.Models;

namespace Syte.Repository
{
    public class CompilationsRepository : ICompilations
    {
        private readonly AppDBContext appDBContent;
        public CompilationsRepository(AppDBContext appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Compilations> ListofCompilations => appDBContent.Compilation;
    }
}
