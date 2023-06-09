﻿using Pioneer_Online_Library.Domain.Model;

namespace Pioneer_Online_Library.MVC.Interface
{
    public interface IAdminService
    {
      
        public Task<Book> CreateBook(Book book);
        public Task<Book> UpdateBook(Book book);
        public Task<Book> DeleteBook(Book ISBN);
    }
}
