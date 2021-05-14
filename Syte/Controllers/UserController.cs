using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Syte.Interfaces;
using Syte.Models;
using Syte.ViewModels;

namespace Syte.Controllers
{
    public class UserController : Controller
    {
        private readonly IUser _allUsers;
        private readonly AppDBContext db;
        public UserController(IUser IAllUsers, AppDBContext db)
        {
            _allUsers = IAllUsers;
            this.db = db;
        }
        public ActionResult Create()
        {
            User obj = new User();
            return View(obj);
            
        }
        [HttpPost]
        public ActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Валидация пройдена";
                db.User.Add(user);
                db.SaveChanges();
                return RedirectToAction();
            }
            ViewBag.Message = "Запрос не прошел валидацию";
            return RedirectToAction();
        }
        }
}
