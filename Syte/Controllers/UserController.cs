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
        public ActionResult Profile(int Id)
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
                return RedirectToRoute(new { controller = "Books", action = "List" });
            }
            ViewBag.Message = "Запрос не прошел валидацию";
            return View(user);
        }
        public ActionResult Login()
        {
            User obj = new User();
            return View(obj);
        }
        [HttpPost]
        public ActionResult Login(User user_in)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Валидация пройдена";
                var users = (from user in db.User select user).ToList();
                foreach(User item in users)
                {
                    if ((item.Login == user_in.Login) && (item.Password == user_in.Password))
                    {
                        Profile(user_in.Id);
                        break;
                    } else
                    {
                        ModelState.AddModelError("User", "Вы ввели неверные данные");
                        return View();
                    }
                }
                return RedirectToRoute(new { controller = "Books", action = "List" });
            }

            ViewBag.Message = "Запрос не прошел валидацию";
            return View(user_in);
        }
    }
}
