using PicApp.Data.Tables;
using SQLite;
using System.Threading.Tasks;

namespace PicApp.Data
{
    public class PhotoRepository
    {
        // Асинхронное подключение к Базе данных
        SQLiteAsyncConnection dbConnection;

        public PhotoRepository(string databasePath)
        {
            // Создаем подключение в методе-конструкторе
            dbConnection = new SQLiteAsyncConnection(databasePath);
        }

        // <summary>
        /// Проверяем на наличие таблицы и создаем в случае необходимости.
        /// </summary>
        public async Task InitDatabase()
        {
            await dbConnection.CreateTableAsync<Photo>();
        }

        /// <summary>
        /// Получение всех фото
        /// </summary>
        public async Task<Photo[]> GetPhotos()
        {
            return await dbConnection.Table<Photo>().ToArrayAsync();
        }

        /// <summary>
        /// Поиск устройства по идентификатору
        /// </summary>
        public async Task<Photo> GetPhoto(int id)
        {
            return await dbConnection.GetAsync<Photo>(id);
        }

        /// <summary>
        /// Удаление фото
        /// </summary>
        public async Task<int> DeletePhoto(Photo photo)
        {
            return await dbConnection.DeleteAsync(photo);
        }

        /// <summary>
        /// Добавление фото
        /// </summary>
        public async Task<int> AddPhoto(Photo photo)
        {
            return await dbConnection.InsertAsync(photo);
        }
    }
}
