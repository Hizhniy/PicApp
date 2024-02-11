using System;
using System.ComponentModel;

namespace PicApp.Models
{
    public class Photo
    {
        private string _name;
        private string _date;

        public Guid Id { get; set; }

        // Обновления этого свойства теперь получают все страницы
        public string Name
        {
            get { return _name; }

            set
            {
                if (_name != value)
                {
                    _name = value;
                    // Вызов уведомления при изменении
                    OnPropertyChanged("Name");
                }
            }
        }

        // Обновления этого свойства теперь получают все страинцы
        public string Date
        {
            get { return _date; }

            set
            {
                if (_date != value)
                {
                    _date = value;
                    // Вызов уведомления при изменении
                    OnPropertyChanged("Date");
                }
            }
        }

        public string Image { get; set; }

        public Photo(string name = null, string image = null, string date = null)
        {
            Id = Guid.NewGuid();
            Name = name;
            Image = image;
            Date = date;
        }

        /// <summary>
        /// Делегат, указывающий на метод-обработчик события PropertyChanged, возникающего при изменении свойств компонента
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Метод, вызывающий событие PropertyChanged
        /// </summary>
        public void OnPropertyChanged(string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
