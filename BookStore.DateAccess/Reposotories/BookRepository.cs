using BookStore.Core;
using BookStore.DataAccess.Entites;
using Microsoft.EntityFrameworkCore;

namespace BookStore.DateAccess.Reposotories;

public class BooksRepository : IBooksRepository
{
    private readonly BookStoreDbContext _context;

    public BooksRepository(BookStoreDbContext context)
    {
        _context = context;
    }

    /* Методы CRUD */
    
    public async Task<List<Book>> Get()
    {
        var bookEntites = await _context.Books
            .AsNoTracking()
            .ToListAsync();

        var books = bookEntites
            .Select(b => Book.Create(b.Id, b.Title, b.Description, b.Price).book)
            .ToList();

        return books;
    }

    public async Task<Guid> Create(Book book)
    {
        var bookEntity = new BookEntity()
        {
            Id = book.Id,
            Title = book.Title,
            Description = book.Description,
            Price = book.Price
        };

        await _context.Books.AddAsync(bookEntity);
        await _context.SaveChangesAsync();

        return bookEntity.Id;
        
    }


    public async Task<Guid> Update(Guid id, string title, string desciption, decimal price)
    {
        _context.Books
            .Where(b => b.Id == id)
            .ExecuteUpdateAsync(s => s
                .SetProperty(b => b.Title, b => title)
                .SetProperty(b => b.Description, b => desciption)
                .SetProperty(b => b.Price, b => price));

        return id;
    }
    
    public async Task<Guid> Delete(Guid id)
    {
        await _context.Books
            .Where(b => b.Id == id)
            .ExecuteDeleteAsync();

        return id;
    }

}