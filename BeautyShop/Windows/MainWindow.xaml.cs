using System.Windows;

using BeautyShop.GlobalClasses;
using BeautyShop.Pages;


namespace BeautyShop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Frame = AppFrame;
            AppFrame.Navigate(new SignInPage());
        }
    }
}
