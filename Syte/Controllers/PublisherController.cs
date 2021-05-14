using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Syte.Interfaces;
using Syte.Models;
using Syte.ViewModels;

namespace Syte.Controllers
{
    public class PublishersController : Controller
    {
        private readonly IPublisher _publisher;
        private readonly AppDBContext db;
        public PublishersController(IPublisher iPublisher, AppDBContext db)
        {
            _publisher = iPublisher;
            this.db = db;
        }

        public ActionResult CreatePublisher()
        {

            ViewBag.Publishers = new SelectList(_publisher.ListofPublishers, "Id", "Name");
            return View();
        }
        [HttpPost]
        public ActionResult CreatePublisher(Publisher publisher)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Валидация пройдена";

                db.Publisher.Add(publisher);
                db.SaveChanges();
                return RedirectToAction();

            }
            ViewBag.Message = "Запрос не прошел валидацию";
            return View();
        }


        public ViewResult ListOfCategories()
        {
            var publishers = _publisher.ListofPublishers;
            return View(publishers);
        }
    }
}
