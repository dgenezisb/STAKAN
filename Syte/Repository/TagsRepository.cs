using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Syte.Interfaces;
using Syte.Models;

namespace Syte.Repository
{
    public class TagsRepository:ITags
    {
        private readonly AppDBContent appDBContent;
        public TagsRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        // получаем только те, которые у нас относятся к опр тегу
        public IEnumerable<Tags> ListofTags => appDBContent.Tags;


    }
}
