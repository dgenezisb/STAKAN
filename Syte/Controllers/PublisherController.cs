using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Syte.Interfaces;
using Syte.ViewModels;

namespace Syte.Controllers
{
    public class PublishersController : Controller
    {
        private readonly IPublisher _publisher;
        public PublishersController(IPublisher iPublisher)
        {
            _publisher = iPublisher;
        }

        public ViewResult ListOfCategories()
        {
            var publishers = _publisher.ListofPublishers;
            return View(publishers);
        }
    }
}
