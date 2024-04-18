using BeautyShop.Contexts;
using BeautyShop.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using BeautyShop.Validators;
using System.Windows;

namespace BeautyShop.ViewModels
{
    public partial class SignUpViewModel : ObservableObject
    {
        [ObservableProperty]
        private Client? _client = new();


        [RelayCommand]
        private void AddClient()
        {
            var context = new BeautyShopDBContext();

            if (ValidatorSignPages.ValidateClient(Client))
            {
                context.Clients.Add(Client);
                context.SaveChanges();
                Client = new Client();
                MessageBox.Show("Регистрация прошла успешно!");
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены от 3 до 30 символов!");
            }

        }
    }
}
