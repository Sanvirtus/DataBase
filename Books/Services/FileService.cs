using System.Collections.Generic;
using System.IO;
using Books.Models;

namespace Books.Services
{
    public class FileService : IFileService
    {
        private readonly string _path;

        public FileService()
        {
            _path = Directory.GetCurrentDirectory();
        }

        public bool OnCreateFile()
        {
            var addDefaultBooks = new AddDefaultBooks();
            var books = addDefaultBooks.AddBooks();

            return OnWriteFile(books);
        }

        public bool OnWriteFile(List<Models.Books> books)
        {
            using (var fileStream = new FileStream(_path + "\\Books.bin", FileMode.Create))
            {
                using (var writer = new BinaryWriter(fileStream))
                {
                    // Запишем общее кол-во записей
                    writer.Write(books.Count);

                    foreach (var book in books)
                    {
                        writer.Write(book.BookId);
                        writer.Write(book.BookName);
                        writer.Write(book.Author);
                        writer.Write(book.PageCount);
                        writer.Write(book.PublishingYear);
                        writer.Write(book.EditionNumber);
                        writer.Write(book.BookPrintNumber);
                        writer.Write((byte) book.BindingType);
                        writer.Write(book.PartyNumber);
                        writer.Write(book.BooksCountInParty);
                        writer.Write(book.PrintingFactoryName);
                    }

                    writer.Close();

                    return true;
                }
            }
        }

        public List<Models.Books> OnReadFile()
        {
            if (!File.Exists(_path + "\\Books.bin"))
            {
                OnCreateFile();
            }

            using (var fileStream = new FileStream(_path + "\\Books.bin", FileMode.Open))
            {
                using (var reader = new BinaryReader(fileStream))
                {
                    var count = reader.ReadInt32();
                    var books = new List<Models.Books>();

                    for (var i = 0; i < count; i++)
                    {
                        books.Add(new Models.Books
                        {
                            BookId = reader.ReadInt32(),
                            BookName = reader.ReadString(),
                            Author = reader.ReadString(),
                            PageCount = reader.ReadInt32(),
                            PublishingYear = reader.ReadInt32(),
                            EditionNumber = reader.ReadInt32(),
                            BookPrintNumber = reader.ReadInt32(),
                            BindingType = (BooksBindingEnum) reader.ReadByte(),
                            PartyNumber = reader.ReadInt32(),
                            BooksCountInParty = reader.ReadInt32(),
                            PrintingFactoryName = reader.ReadString()
                        });
                    }

                    return books;
                }
            }
        }
    }
}