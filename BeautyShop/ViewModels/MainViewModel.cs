using BeautyShop.GlobalClasses;
using BeautyShop.Pages;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;


namespace BeautyShop.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
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
    }
}
