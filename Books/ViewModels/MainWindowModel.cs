using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows;
using Books.Models;
using Books.Services;
using Books.Views;

namespace Books
{
    public class MainWindowModel
    {
        private readonly IFileService _fileService;
        private readonly string _path;

        public MainWindowModel(IFileService fileService)
        {
            _fileService = fileService;
            _path = Directory.GetCurrentDirectory();

            RefreshCommand = new RelayCommand(l => OnRefreshAsync());
            AddBookCommand = new RelayCommand(l => OnAddBook());
            EditBookCommand = new RelayCommand(l => OnEditBook());
            DeleteBookCommand = new RelayCommand(l => OnDeleteBook());
            PreviousPageCommand = new RelayCommand(l => OnPreviousPage());
            NextPageCommand = new RelayCommand(l => OnNextPage());
            OriginalBooks = new ObservableCollection<Models.Books>();
            Books = new ObservableCollection<Models.Books>();

            OnInitial();
        }

        #region Variables

        #region Commands

        /// <summary>
        /// Обновить список
        /// </summary>
        public RelayCommand RefreshCommand { get; set; }

        /// <summary>
        /// Добавить новую книгу
        /// </summary>
        public RelayCommand AddBookCommand { get; set; }

        /// <summary>
        /// Редактировать книгу
        /// </summary>
        public RelayCommand EditBookCommand { get; set; }

        /// <summary>
        /// Удалить книгу
        /// </summary>
        public RelayCommand DeleteBookCommand { get; set; }

        /// <summary>
        /// Предыдущая страница
        /// </summary>
        public RelayCommand PreviousPageCommand { get; set; }

        /// <summary>
        /// Следующая страница
        /// </summary>
        public RelayCommand NextPageCommand { get; set; }

        #endregion

        /// <summary>
        /// Книги
        /// </summary>
        private ObservableCollection<Models.Books> OriginalBooks { get; set; }

        /// <summary>
        /// Книги
        /// </summary>
        public ObservableCollection<Models.Books> Books { get; set; }

        /// <summary>
        /// Выбранная книга
        /// </summary>
        public Models.Books SelectedBook { get; set; }

        /// <summary>
        /// Текущая страница
        /// </summary>
        public int CurrentPage { get; set; }

        #endregion

        /// <summary>
        /// Инициализация приложения
        /// </summary>
        private void OnInitial()
        {
            try
            {
                // Если файла не существует
                if (!File.Exists(_path + "\\Books.bin"))
                {
                    var result = _fileService.OnCreateFile();
                    if (result != true)
                    {
                        throw new Exception();
                    }
                }

                CurrentPage = 1;

                RefreshCommand.Execute(null);
            }
            catch
            {
                MessageBox.Show("Ошибка при инициализации книг!", "Ошибка!", MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Команда обновления списка
        /// </summary>
        private void OnRefreshAsync()
        {
            try
            {
                var books = _fileService.OnReadFile();
                if (books.Count > 0)
                {
                    OriginalBooks.Clear();
                    foreach (var book in books)
                    {
                        OriginalBooks.Add(book);
                    }

                    UpdateVisibleBooks(CurrentPage);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при попытке чтений книг из файла!", "Ошибка!", MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Команда добавления новой книги
        /// </summary>
        private void OnAddBook()
        {
            try
            {
                var model = new ModifyWindowsView(new Models.Books());
                if (model.ShowDialog() != true) return;

                var lastBookId = OriginalBooks.Select(l => l.BookId).Last();

                var book = model.Books;
                book.BindingType = book.IsSoft ? BooksBindingEnum.Мягкий : BooksBindingEnum.Твердый;
                book.BookId = lastBookId + 1;

                OriginalBooks.Add(book);

                if (File.Exists(_path + "\\Books.bin"))
                {
                    File.Delete(_path + "\\Books.bin");
                }

                var result = _fileService.OnWriteFile(OriginalBooks.ToList());
                if (result != true)
                {
                    throw new Exception();
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении записи!", "Ошибка!", MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
            finally
            {
                RefreshCommand.Execute(null);
            }
        }

        /// <summary>
        /// Команда редактирования книги
        /// </summary>
        private void OnEditBook()
        {
            try
            {
                if (SelectedBook != null)
                {
                    var book = SelectedBook;
                    if (SelectedBook.BindingType == BooksBindingEnum.Мягкий)
                    {
                        book.IsSoft = true;
                    }

                    var model = new ModifyWindowsView(book);

                    if (model.ShowDialog() == true)
                    {
                        var index = OriginalBooks.ToList().FindIndex(l => l.BookId == model.Books.BookId);
                        OriginalBooks[index] = new Models.Books()
                        {
                            BookId = model.Books.BookId,
                            BookName = model.Books.BookName,
                            Author = model.Books.Author,
                            PageCount = model.Books.PageCount,
                            PublishingYear = model.Books.PublishingYear,
                            EditionNumber = model.Books.EditionNumber,
                            BookPrintNumber = model.Books.BookPrintNumber,
                            BindingType = model.Books.IsSoft ? BooksBindingEnum.Мягкий : BooksBindingEnum.Твердый,
                            PartyNumber = model.Books.PartyNumber,
                            BooksCountInParty = model.Books.BooksCountInParty,
                            PrintingFactoryName = model.Books.PrintingFactoryName,
                        };

                        if (File.Exists(_path + "\\Books.bin"))
                        {
                            File.Delete(_path + "\\Books.bin");
                        }

                        var result = _fileService.OnWriteFile(OriginalBooks.ToList());
                        if (result != true)
                        {
                            throw new Exception();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Пожалуйста, выберите книгу для редактирования!", "Уведомление!",
                        MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при редактировании записи!", "Ошибка!", MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
            finally
            {
                RefreshCommand.Execute(null);
            }
        }

        /// <summary>
        /// Команда удаления книги
        /// </summary>
        private void OnDeleteBook()
        {
            try
            {
                if (SelectedBook != null)
                {
                    if (MessageBox.Show("Удалить выбранную запись?", "Подтвердите удаление",
                            MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        var book = OriginalBooks.Single(l => l.BookId == SelectedBook.BookId);
                        OriginalBooks.Remove(book);

                        if (File.Exists(_path + "\\Books.bin"))
                        {
                            File.Delete(_path + "\\Books.bin");
                        }

                        var result = _fileService.OnWriteFile(OriginalBooks.ToList());
                        if (result != true)
                        {
                            throw new Exception();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Пожалуйста, выберите книгу для удаления!", "Уведомление!",
                        MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при удалении записи!", "Ошибка!", MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
            finally
            {
                RefreshCommand.Execute(null);
            }
        }

        /// <summary>
        /// Команда перехода на предыдущую страницу
        /// </summary>
        private void OnPreviousPage()
        {
            if (CurrentPage <= 1) return;
            CurrentPage--;
            UpdateVisibleBooks(CurrentPage);
        }

        /// <summary>
        /// Команда перехода на следующую страницу
        /// </summary>
        private void OnNextPage()
        {
            if (OriginalBooks.Count <= 50 * CurrentPage - 1) return;
            CurrentPage++;
            UpdateVisibleBooks(CurrentPage);
        }

        private void UpdateVisibleBooks(int page)
        {
            Books.Clear();
            for (var i = (page - 1) * 50; i < page * 50; i++)
            {
                if (i < OriginalBooks.Count)
                {
                    Books.Add(OriginalBooks[i]);
                }
            }
        }
    }
}