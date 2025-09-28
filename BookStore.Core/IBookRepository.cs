using BookStore.Core;

namespace BookStore.DateAccess.Reposotories;

public interface IBookRepository
{
    Task<List<Book>> Get();
    Task<Guid> Create(Book book);
    Task<Guid> Update(Guid id, string title, string desciption, decimal price);
    Task<Guid> Delete(Guid id);
}