using Entities.Exceptions;
using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BookManager : IBookService
    {
        private readonly IRepositoryManager _manager;
        private readonly ILoggerService _logger;

        public BookManager(IRepositoryManager manager, 
            ILoggerService logger)
        {
            _manager = manager;
            _logger = logger;
        }

        public Book CreateOneBook(Book book)
        {
            _manager.Book.CreateOneBook(book);
            _manager.Save();
            return book;
        }

        public void DeleteOneBook(int id, bool trackChanges)
        {
            // check entity 
            var entity = _manager.Book.GetOneBookById(id, trackChanges);
            if (entity is null)
                throw new BookNotFoundException(id);
            
            _manager.Book.DeleteOneBook(entity);
            _manager.Save();
        }

        public IEnumerable<Book> GetAllBooks(bool trackChanges)
        {
            return _manager.Book.GetAllBooks(trackChanges);
        }

        public Book GetOneBookById(int id, bool trackChanges)
        {
            var book =  _manager.Book.GetOneBookById(id,trackChanges);
            if (book is null)
                throw new BookNotFoundException(id);
            return book;
        }

        public void UpdateOneBook(int id, Book book, bool trackChanges)
        {
            // check entity
            var entity = _manager.Book.GetOneBookById(id, trackChanges);
            if (entity is null)
                throw new BookNotFoundException(id);
           
            entity.Title = book.Title;
            entity.Price = book.Price;

            _manager.Book.Update(entity);
            _manager.Save();
        }
    }
}
