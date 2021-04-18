using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Syte.Interfaces;
using Syte.Models;

namespace Syte.Repository
{
    public class ReviewsRepository : IReviews
    {
        private readonly AppDBContext appDBContent;
        public ReviewsRepository(AppDBContext appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Reviews> ListofReviews => appDBContent.Reviews;
    }
}
