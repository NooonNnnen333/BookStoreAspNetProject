namespace BookStore.Contracts;


    public record BooksRespons(
        Guid Id,
        string Title,
        string Descripton,
        decimal Price);
