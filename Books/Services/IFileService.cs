using System.Collections.Generic;

namespace Books.Services
{
    public interface IFileService
    {
        /// <summary>
        /// Создание файла
        /// </summary>
        bool OnCreateFile();

        /// <summary>
        /// Запись файла
        /// </summary>
        /// <param name="books"></param>
        /// <returns></returns>
        bool OnWriteFile(List<Models.Books> books);

        /// <summary>
        /// Чтение файла
        /// </summary>
        List<Models.Books> OnReadFile();
    }
}