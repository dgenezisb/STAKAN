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
                content.Book.AddRange(Books.Select(c => c.Value));
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));
            if (!content.Authors.Any())
                content.Authors.AddRange(Authors.Select(c => c.Value));
            if (!content.Reviews.Any())
                content.Reviews.AddRange(Reviews.Select(c => c.Value));
            if (!content.Publisher.Any())
                content.Publisher.AddRange(Publisher.Select(c => c.Value));
            if (!content.Compilation.Any())
                content.Compilation.AddRange(Compilations.Select(c => c.Value));
            if (!content.MyBooks.Any())
                content.MyBooks.AddRange(MyBooks.Select(c => c.Value));
            if (!content.User.Any())
                content.User.AddRange(User.Select(c => c.Value));
            //BookTags();
            content.SaveChanges();
        }
        private static Dictionary<string, Book> book;
        public static Dictionary<string, Book> Books
        {
            get
            {
                if (book == null)
                {
                    var list = new Book[]
                    {
                        new Book
                        {
                            Name = "Приключения электроника",
                            Author = Authors["Велтистов"],
                            Description = "Приключения Электроника - знаменитая повесть Евгения Велтистова о приключениях Сережи Сыроежкина и его двойника - робота Электроника.",
                            Image = "https://forkids.newbookshop.ru/pictures/1024121942.jpg",
                            IsFavourite = false,
                            Category = Categories["Научная фантастика"],
                            Publisher = Publisher["Добрая книга"],
                            Compilation = Compilations["Детские книги"]
                        },
                        new Book
                        {
                            Name = "Муму",
                            Author = Authors["Тургенев"],
                            Description = "Рассказ русского писателя Ивана Сергеевича Тургенева, написанный в 1852 году.",
                            Image = "https://productforhomeandgarden.ru/img/1023750205.jpg",
                            IsFavourite = true,
                            Category = Categories["Детские"],
                            Publisher = Publisher["Дрофа"],
                            Compilation = Compilations["Детские книги"]
                        },
                        new Book
                        {
                            Name = "Азазель",
                            Author = Authors["Акунин"],
                            Description = "Книга Бориса Акунина, первый роман из серии о необыкновенном сыщике Эрасте Петровиче Фандорине «Приключения Эраста Фандорина».",
                            Image = "https://productforhomeandgarden.ru/img/1016539304.jpg",
                            IsFavourite = false,
                            Category = Categories["Детективы"],
                            Publisher = Publisher["ДЕАН"],
                            Compilation = Compilations["Детские книги"]
                        },
                        new Book
                        {
                            Name = "Остров сокровищ",
                            Author = Authors["Стивенсон"],
                            Description = "Роман шотландского писателя Роберта Стивенсона о приключениях, связанных с поиском сокровищ, спрятанных капитаном Флинтом на необитаемом острове.",
                            Image = "https://cosmetics.minemegashop.ru/images/1022251489.jpg",
                            IsFavourite = true,
                            Category = Categories["Приключения"],
                            Publisher = Publisher["Десяточка"],
                            Compilation = Compilations["Детские книги"]
                        }
                    };
                    book = new Dictionary<string, Book>();
                    foreach (Book elem in list)
                        book.Add(elem.Name, elem);

                }
                return book;
            }
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


        private static Dictionary<string, Reviews> review;
        public static Dictionary<string, Reviews> Reviews
        {
            get
            {
                if (review == null)
                {
                    var list = new Reviews[]
                    {
                        new Reviews {Name = "Петя", Review = "Реценция 1", Book = Books["Азазель"]},
                        new Reviews {Name = "Вася",Review = "Реценция 2", Book = Books["Муму"]},
                        new Reviews {Name = "Игорь", Review = "Реценция 3", Book = Books["Приключения электроника"]},
                        new Reviews {Name = "Ваня", Review = "Реценция 4", Book = Books["Остров сокровищ"]}
                    };
                    review = new Dictionary<string, Reviews>();
                    foreach (Reviews elem in list)
                        review.Add(elem.Name, elem);
                }
                return review;
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

        private static Dictionary<string, Compilations> compilation;
        public static Dictionary<string, Compilations> Compilations
        {
            get
            {
                if (compilation == null)
                {
                    var list = new Compilations[]
                    {
                         new Compilations {Name = "Детские книги", Desc="Книги для детей всех возрастов"}
                    };
                    compilation = new Dictionary<string, Compilations>();
                    foreach (Compilations elem in list)
                        compilation.Add(elem.Name, elem);
                }
                return compilation;
            }
        }

        private static Dictionary<string, User> user;
        public static Dictionary<string, User> User
        {
            get
            {
                if (user == null)
                {
                    var list = new User[]
                    {
                         new User {Name = "Читатель",Age=21 },
                         new User {Name = "Модератор", Age=40}
                    };
                    user = new Dictionary<string, User>();
                    foreach (User elem in list)
                        user.Add(elem.Name, elem);
                }
                return user;
            }
        }

        private static Dictionary<string, MyBooks> mybooks;
        public static Dictionary<string, MyBooks> MyBooks
        {
            get
            {
                if (mybooks == null)
                {
                    var list = new MyBooks[]
                    {
                         new MyBooks {Name = "Моя любимая книга", User = User["Читатель"]}
                    };
                    mybooks = new Dictionary<string, MyBooks>();
                    foreach (MyBooks elem in list)
                        mybooks.Add(elem.Name, elem);
                }
                return mybooks;
            }
        }

        private static Dictionary<string, Tags> tag;
        public static Dictionary<string, Tags> Tags
        {
            get
            {
                if (tag == null)
                {
                    var list = new Tags[]
                    {
                        new Tags(Guid.NewGuid(), "крутое", Books["Приключения электроника"], Books["Остров сокровищ"]),
                        new Tags(Guid.NewGuid(), "грустное", Books["Муму"], Books["Азазель"]),
                    };
                    tag = new Dictionary<string, Tags>();
                    foreach (Tags elem in list)
                        tag.Add(elem.Name, elem);
                }
                return tag;
            }
        }
        //public static void BookTags()
        //{
        //    Tags["грустное"].Books.Add(Books["Муму"]);
        //    Tags["грустное"].Books.Add(Books["Азазель"]);
        //    Tags["крутое"].Books.Add(Books["Приключения электроника"]);
        //    Tags["крутое"].Books.Add(Books["Остров сокровищ"]);
        //}
    }
}