﻿using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Syte.Models;

namespace Syte
{
    public class DBObjects
    {
        public static void Initial(AppDBContext content)
        {

            if (!content.Category.Any())
            
                content.Category.AddRange(Categories.Select(c => c.Value));
            

            if (!content.Book.Any())
            {
                content.AddRange(
                    new Book
                    {
                        Name = "Приключения электроника",
                        Author = "Евгений Велтистов",
                        Description = "Приключения Электроника - знаменитая повесть Евгения Велтистова о приключениях Сережи Сыроежкина и его двойника - робота Электроника.",
                        Image = "https://forkids.newbookshop.ru/pictures/1024121942.jpg",
                        IsFavourite = false,
                        Category = Categories["Научная фантастика"]
                    },
                    new Book
                    {
                        Name = "Муму",
                        Author = "Иван Тургенев",
                        Description = "Рассказ русского писателя Ивана Сергеевича Тургенева, написанный в 1852 году.",
                        Image = "https://productforhomeandgarden.ru/img/1023750205.jpg",
                        IsFavourite = true,
                        Category = Categories["Детские"]
                    },
                    new Book
                    {
                        Name = "Азазазель",
                        Author = "Борис Акунин",
                        Description = "Книга Бориса Акунина, первый роман из серии о необыкновенном сыщике Эрасте Петровиче Фандорине «Приключения Эраста Фандорина».",
                        Image = "https://productforhomeandgarden.ru/img/1016539304.jpg",
                        IsFavourite = false,
                        Category = Categories["Детективы"]
                    },
                    new Book
                    {
                        Name = "Остров сокровищ",
                        Author = "Роберт Стивенсон",
                        Description = "Роман шотландского писателя Роберта Стивенсона о приключениях, связанных с поиском сокровищ, спрятанных капитаном Флинтом на необитаемом острове.",
                        Image = "https://cosmetics.minemegashop.ru/images/1022251489.jpg",
                        IsFavourite = true,
                        Category = Categories["Приключения"]
                    }
                );
            }

            content.SaveChanges();

        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category {CategoryName = "Детские", Description="Книги для детей",},
                        new Category {CategoryName = "Детективы", Description="Таинтвенные истории",},
                        new Category {CategoryName = "Научная фантастика", Description="Путешествия в мирах высоких технологий"},
                        new Category {CategoryName = "Приключения", Description="Истории об отважных путешественниках"}
                    };
                    category = new Dictionary<string, Category>();
                    foreach (Category elem in list)
                        category.Add(elem.CategoryName, elem);
                }
                return category;
            }
        }
    }
}