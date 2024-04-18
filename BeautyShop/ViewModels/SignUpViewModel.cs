using BeautyShop.Contexts;
using BeautyShop.Pages;
using BeautyShop.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using BeautyShop.Validators;
using System.Windows;
using BeautyShop.GlobalClasses;

namespace BeautyShop.ViewModels
{
    public partial class SignUpViewModel : ObservableObject
    {
        [ObservableProperty]
        private Client? _registerClient = new();


        [RelayCommand]
        private void AddClient()
        {
            var context = new BeautyShopDBContext();

            if (ValidatorSignPages.ValidateClient(RegisterClient))
            {
                context.Clients.Add(RegisterClient);
                context.SaveChanges();
                RegisterClient = new Client();
                MessageBox.Show("Регистрация прошла успешно!");
                MainFrame.Frame.Navigate(new SignInPage());
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены от 3 до 30 символов!");
            }

        }
    }
}
