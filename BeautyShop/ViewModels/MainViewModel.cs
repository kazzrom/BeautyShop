using BeautyShop.GlobalClasses;
using BeautyShop.Messages;
using BeautyShop.Models;
using BeautyShop.Pages;
using BeautyShop.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;

namespace BeautyShop.ViewModels
{
    public partial class MainViewModel : ObservableObject, IRecipient<LoggedInClientMessage>
    {
        [ObservableProperty]
        private Client _client;

        public MainViewModel()
        {
            WeakReferenceMessenger.Default.Register(this);
        }

        [RelayCommand]
        private void GoSignUpPage()
        {
            MainFrame.Frame.Navigate(new SignUpPage());
        }
        
        [RelayCommand]
        private void GoSignInPage()
        {
            MainFrame.Frame.Navigate(new SignInPage());
        }

        [RelayCommand]
        private void ShowAboutUs()
        {
            var aboutUs = new AboutUs();
            aboutUs.ShowDialog();
        }
        public void Receive(LoggedInClientMessage message)
        {
            Client = message.Value;
            WeakReferenceMessenger.Default.UnregisterAll(this);
        }
    }
}
