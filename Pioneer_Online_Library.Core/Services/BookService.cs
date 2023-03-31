using Pioneer_Online_Library.Core.Interface;
using Pioneer_Online_Library.Domain.Model;
using Pioneer_Online_Library.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pioneer_Online_Library.Core.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public Book GetByAuthor(string author)
        {
            return _bookRepository.GetBookByAuthor(author);
        }

        public Book GetByDatePublished(string datePublished)
        {
            return _bookRepository.GetBookByYearPublished(datePublished);
        }

        public Book GetByISBN(string ISBN)
        {
            return _bookRepository.GetBookByISBN(ISBN);
        }

        public Book GetByPublisher(string publisher)
        {
            return _bookRepository.GetBookByPublisher(publisher);
        }

        public Book GetByTitle(string title)
        {
            return _bookRepository.GetBookByTitle(title);
        }
    }
}
