using BlazorWebCRUD.Server.Interfaces;
using BlazorWebCRUD.Server.Models;
using BlazorWebCRUD.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorWebCRUD.Server.Services
{
    public class BookManager : IBook
    {
        readonly DatabaseContext _dbContext = new();
        public BookManager(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddBook(Book book)
        {
            try
            {
                _dbContext.Books.Add(book);
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void DeleteBook(int id)
        {
            try
            {
                Book? book = _dbContext.Books.Find(id);
                if (book != null)
                {
                    _dbContext.Books.Remove(book);
                    _dbContext.SaveChanges();
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }

        public Book GetBookData(int id)
        {
            try
            {
                Book? book = _dbContext.Books.Find(id);
                if (book != null)
                {
                    return book;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }

        public List<Book> GetBookDetails()
        {
            try
            {
                return _dbContext.Books.ToList();
            }
            catch
            {
                throw;
            }
        }

        public void UpdateBookDetails(Book book)
        {
            try
            {
                _dbContext.Entry(book).State = EntityState.Modified;
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
