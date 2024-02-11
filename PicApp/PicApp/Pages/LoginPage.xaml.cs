using PicApp.Data;
using PicApp.Models;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PicApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        // Переменная счетчика
        public static int loginCouner = 0;

        public const string LABEL_TEXT = "Установите пин-код (4 символа):";
        public const string BUTTON_TEXT = "Сохранить";

        public string Login { get; set; }

        public LoginPage()
        {
            InitializeComponent();
        }

        User user = new User();

        private async void enterButton_Clicked(object sender, EventArgs e)
        {
            Login = pinForEntry.Text;

            if (loginCouner > 0)
            {
                loginButton.Text = "Введите пин-код:";
                enterButton.Text = "Войти";
            }

            if (String.IsNullOrEmpty(Login))
            {
                await DisplayAlert("Ошибка", $"Поле ввода не должно быть пустым!", "OK");
                return;
            }
            else if (Login.Length != 4)
            {
                await DisplayAlert("Ошибка", $"Пин-код должен длинной в 4 символа!", "OK");
                return;
            }
            else if (user.Password == Login && loginCouner > 0)
            {
                await Navigation.PushAsync(new GalleryPage());
            }
            else if (loginCouner == 0)
            {
                user.Password = Login;
                await DisplayAlert(null, $"Ваш пин-код {Login} сохранен!", "OK");
                await Navigation.PushAsync(new GalleryPage());
            }
            else
            {
                await DisplayAlert("Ошибка", $"Неверный пароль!", "OK");
                return;
            }

            // Увеличиваем счетчик
            loginCouner += 1;
        }
    }
}