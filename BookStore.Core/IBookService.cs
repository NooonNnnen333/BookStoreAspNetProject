using BookStore.Core;

namespace BookStore.Application;

public interface IBookService
{
    Task<List<Book>> GetAllBook();
    Task<Guid> CreateBook(Book book);
    Task<Guid> UpdateBook(Guid id, string title, string description, decimal price);
    Task<Guid> DeleteBook(Guid id);
}