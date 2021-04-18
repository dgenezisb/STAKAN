using Microsoft.AspNetCore.Builder;
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
            if (!content.Book.Any())
            {
                content.AddRange(
                    new Book
                    {
                        Name = "Приключения электроника",
                        Author = Authors["Велтистов"],
                        Description = "Приключения Электроника - знаменитая повесть Евгения Велтистова о приключениях Сережи Сыроежкина и его двойника - робота Электроника.",
                        Image = "https://forkids.newbookshop.ru/pictures/1024121942.jpg",
                        IsFavourite = false,
                        Category = Categories["Научная фантастика"],
                       // Publisher = Publisher["ДЕАН"]
                    },
                    new Book
                    {
                        Name = "Муму",
                        Author = Authors["Тургенев"],
                        Description = "Рассказ русского писателя Ивана Сергеевича Тургенева, написанный в 1852 году.",
                        Image = "https://productforhomeandgarden.ru/img/1023750205.jpg",
                        IsFavourite = true,
                        Category = Categories["Детские"],
                       // Publisher = Publisher["Десяточка"]
                    },
                    new Book
                    {
                        Name = "Азазель",
                        Author = Authors["Акунин"],
                        Description = "Книга Бориса Акунина, первый роман из серии о необыкновенном сыщике Эрасте Петровиче Фандорине «Приключения Эраста Фандорина».",
                        Image = "https://productforhomeandgarden.ru/img/1016539304.jpg",
                        IsFavourite = false,
                        Category = Categories["Детективы"],
                       // Publisher = Publisher["Дрофа"]
                    },
                    new Book
                    {
                        Name = "Остров сокровищ",
                        Author = Authors["Стивенсон"],
                        Description = "Роман шотландского писателя Роберта Стивенсона о приключениях, связанных с поиском сокровищ, спрятанных капитаном Флинтом на необитаемом острове.",
                        Image = "https://cosmetics.minemegashop.ru/images/1022251489.jpg",
                        IsFavourite = true,
                        Category = Categories["Приключения"],
                        //Publisher = Publisher["Добрая книга"]
                    }
                );
        }

            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));
            if (!content.Authors.Any())
                content.Authors.AddRange(Authors.Select(c => c.Value));
            if (!content.Publishers.Any())
                content.Publishers.AddRange(Publisher.Select(c => c.Value));

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

        private static Dictionary<string, Authors> authors;
        public static Dictionary<string, Authors> Authors
        {
            get
            {
                if (authors == null)
                {
                    var list = new Authors[]
                    {
                        new Authors {Surname="Велтистов", Name = "Евгений", DateBD="1934/7/21",DateOfdeath="1989/9/1"},
                        new Authors {Surname="Тургенев", Name = "Иван", DateBD="1818/11/9",DateOfdeath="1883/9/3"},
                        new Authors {Surname="Акунин", Name = "Борис", DateBD="1956/5/20",DateOfdeath="still alive"},
                        new Authors {Surname="Стивенсон", Name = "Роберт", DateBD="1850/11/13",DateOfdeath="1894/12/3"}
                    };
                    authors = new Dictionary<string, Authors>();
                    foreach (Authors elem in list)
                        authors.Add(elem.Surname, elem);
                }
                return authors;
            }
        }    
        private static Dictionary<string, Publisher> publishers;
        public static Dictionary<string, Publisher> Publisher
        {
            get
            {
                if (publishers == null)
                {
                    var list = new Publisher[]
                    {
                        new Publisher {Name="Десяточка", Description = "Группа компаний «Десяточка»", Commercial=true},
                        new Publisher {Name="ДЕАН", Description = "Издательство ДЕАН", Commercial=false},
                        new Publisher {Name="Добрая книга", Description = "«Добрая книга»", Commercial=true},
                        new Publisher {Name="Дрофа", Description = "«Дрофа»", Commercial=false}
                    };
                    publishers = new Dictionary<string, Publisher>();
                    foreach (Publisher elem in list)
                        publishers.Add(elem.Name, elem);
                }
                return publishers;
            }
        }
    }
}
