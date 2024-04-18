using BeautyShop.Contexts;
using BeautyShop.GlobalClasses;
using BeautyShop.Messages;
using BeautyShop.Models;
using BeautyShop.Pages;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BeautyShop.ViewModels
{
    public partial class SignInViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _email;

        [RelayCommand]
        private void Login()
        {
            var context = new BeautyShopDBContext();

            Client[] response = null;

            if (Email != null)
            {
                response = context.Clients.Where(client => client.Email == Email).ToArray();
            }
            else
            {
                MessageBox.Show("Введите email!");
                return;
            }

            if (response != null && response.Length == 1)
            {
                MainFrame.Frame.Navigate(new ClientPage());
                WeakReferenceMessenger.Default.Send(new LoggedInClientMessage(response[0]));
            }
            else
            {
                MessageBox.Show("Такого пользователя не существует");
            }
        }
    }
}
