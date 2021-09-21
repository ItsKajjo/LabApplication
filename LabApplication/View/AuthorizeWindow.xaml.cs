using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using LabApplication.Services;
using LabApplication.ViewModel;
namespace LabApplication
{
    /// <summary>
    /// Interaction logic for AuthorizeWindow.xaml
    /// </summary>
    public partial class AuthorizeWindow : Window
    {
        public AuthorizeWindow()
        {
            InitializeComponent();

            ViewModel = new AuthorizeWindowViewModel();
            DataContext = ViewModel;
        }

        public AuthorizeWindowViewModel ViewModel { get; set; }
        // костыльчик из-за невозможности биндинга passwordbox (хотя в прицнипе не такой уже и костыль)
        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            PasswordUnmaskedTextBox.Text = PasswordBox.Password;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (DataContext is AuthorizeWindowViewModel vm)
            {
                vm.HideWindowAction += () =>
                {
                    this.Hide();
                };
            }
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
