using BookStore.Core;
using BookStore.DataAccess.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.DataAccess.Configurations;

public class BookConfiguration : IEntityTypeConfiguration<BookEntity>
{
    public void Configure(EntityTypeBuilder<BookEntity> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(b => b.Id)
            .HasMaxLength(Book.MAX_LENGHT)
            .IsRequired();
        
        


    }
        
        
        
}
