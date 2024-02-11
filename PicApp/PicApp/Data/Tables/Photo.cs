using SQLite;
using System;

namespace PicApp.Data.Tables
{
    /// <summary>
    /// Класс - модель таблицы фото
    /// </summary>
    [Table("Photos")]
    public class Photo
    {
        [PrimaryKey]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public string Image { get; set; }
    }
}
