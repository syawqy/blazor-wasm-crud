using BlazorWebCRUD.Shared.Models;

namespace BlazorWebCRUD.Server.Interfaces
{
    public interface IBook
    {
        public List<Book> GetBookDetails();
        public void AddBook(Book book);
        public void UpdateBookDetails(Book book);
        public Book GetBookData(int id);
        public void DeleteBook(int id);
    }
}
