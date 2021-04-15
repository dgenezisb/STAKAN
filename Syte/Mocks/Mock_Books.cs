using Syte.Interfaces;
using Syte.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Syte.Mocks
{
    public class Mock_Books : IAllBooks
    {
        private readonly IBooksCategories _categoryBooks = new Mock_Category();
        public IEnumerable<Book> Books 
        {
            get
            {
                return new List<Book>                                                       //ЗДЕСЬ ОПИСАТЬ ВСЕ КНИГИ НА САЙТЕ
                {
                    new Book{Name = "Приключения электроника", 
                            Author="Евгений Велтистов", 
                            Description = "Приключения Электроника - знаменитая повесть Евгения Велтистова о приключениях Сережи Сыроежкина и его двойника - робота Электроника.", 
                            Image = "https://forkids.newbookshop.ru/pictures/1024121942.jpg", 
                            IsFavourite = false ,  
                            Category= _categoryBooks.ListofCategories.ElementAt(2) },
                    new Book{Name = "Муму", 
                             Author="Иван Тургенев",
                             Description = "Рассказ русского писателя Ивана Сергеевича Тургенева, написанный в 1852 году.",
                             Image = "https://productforhomeandgarden.ru/img/1023750205.jpg",IsFavourite = true, 
                             Category= _categoryBooks.ListofCategories.ElementAt(0)},
                    new Book{Name = "Азазазель", 
                             Author="Борис Акунин" , 
                             Description = "Книга Бориса Акунина, первый роман из серии о необыкновенном сыщике Эрасте Петровиче Фандорине «Приключения Эраста Фандорина».",
                             Image = "https://productforhomeandgarden.ru/img/1016539304.jpg",
                             IsFavourite = false, 
                             Category= _categoryBooks.ListofCategories.ElementAt(1)},
                    new Book{Name = "Остров сокровищ", 
                             Author="Роберт Стивенсон" , 
                             Description = "Роман шотландского писателя Роберта Стивенсона о приключениях, связанных с поиском сокровищ, спрятанных капитаном Флинтом на необитаемом острове.",
                             Image = "https://cosmetics.minemegashop.ru/images/1022251489.jpg",
                             IsFavourite = true, 
                             Category= _categoryBooks.ListofCategories.ElementAt(3)},
                };
            }
            set => throw new NotImplementedException(); //Тут реализовать добавление книг
        }
        public IEnumerable<Book> GetFavouriteBooks { get; set; }    //Реализовать функцию для получения всех элементом с параметром Favourite = true и возможность добавлять в этот список киниг(хз честно как) ))
        public IEnumerable<Book> GetAuthorsBooks { get => throw new NotImplementedException();}   //Реализовать функцию для получения всех книг автора         
        

        public Book GetObjectBook(int BookID)
        {
            throw new NotImplementedException();
        }
    }
}
