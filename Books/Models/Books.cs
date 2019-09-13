namespace Books.Models
{
    public class Books
    {
        /// <summary>
        /// Id книги
        /// </summary>
        public int BookId { get; set; }

        /// <summary>
        /// Название книги
        /// </summary>
        public string BookName { get; set; }

        /// <summary>
        /// Автор
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Кол-во страниц
        /// </summary>
        public int PageCount { get; set; }

        /// <summary>
        /// Год издания
        /// </summary>
        public int PublishingYear { get; set; }

        /// <summary>
        /// Номер издания
        /// </summary>
        public int EditionNumber { get; set; }

        /// <summary>
        /// Номер книги в печати
        /// </summary>
        public int BookPrintNumber { get; set; }

        /// <summary>
        /// Тип переплёта
        /// </summary>
        public BooksBindingEnum BindingType { get; set; }

        /// <summary>
        /// Мягкая обложка
        /// </summary>
        public bool IsSoft { get; set; }

        /// <summary>
        /// Номер партии
        /// </summary>
        public int PartyNumber { get; set; }

        /// <summary>
        /// Кол-во книг в партии
        /// </summary>
        public int BooksCountInParty { get; set; }

        /// <summary>
        /// Название печатной фабрики
        /// </summary>
        public string PrintingFactoryName { get; set; }
    }
}