using BookStore.Core;

namespace BookStore.DateAccess.Reposotories;

public interface IBooksRepository
{
    Task<List<Book>> Get();
    Task<Guid> Create(Book book);
    Task<Guid> Update(Guid id, string title, string desciption, decimal price);
    Task<Guid> Delete(Guid id);
}