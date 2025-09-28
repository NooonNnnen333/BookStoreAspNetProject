namespace BookStore.Core
{

    public class Book
    {
        public const int MAX_LENGHT = 250; // Максимальная длина

        private Book(Guid id, string title, string description, decimal price) // "Зашищённый" конструктор
        {
            Id = id;
            Title = title;
            Description = description;
            Price = price;

        }

        public Guid Id { get; }
        public string Title { get; } = string.Empty; // string.Empty = ""
        public string Description { get; } = string.Empty;
        public decimal Price { get; }

        public static (Book book, string Error) Create(Guid id, string tittle, string description,
            decimal price)
        {
            var error = string.Empty;

            if (string.IsNullOrEmpty(tittle) || tittle.Length > MAX_LENGHT)
            {
                error = "Tittle can not be empaty or longer then 250 sybols";
            }

            var book = new Book(id, tittle, description, price);

            return (book, error);

        }

    }

    
}