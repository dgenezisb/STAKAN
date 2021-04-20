using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Syte.Interfaces;
using Syte.Models;

namespace Syte.Repository
{
    public class PublisherRepository : IPublisher
    {
        private readonly AppDBContext appDBContent;
        public PublisherRepository(AppDBContext appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Publisher> ListofPublishers => appDBContent.Publisher;
    }
}
