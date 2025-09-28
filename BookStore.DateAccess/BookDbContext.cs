using BookStore.DataAccess.Entites;
using Microsoft.EntityFrameworkCore;

namespace BookStore.DateAccess;

public class BookStoreDbContext : DbContext
{
    
    public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options) : base(options)
    {
        
    }

    public DbSet<BookEntity> Books { set; get; }

}