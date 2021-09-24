using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using LabApplication.Services;
using LabApplication.ViewModel;

namespace LabApplication.View
{
    /// <summary>
    /// Interaction logic for HomeWindow.xaml
    /// </summary>
    public partial class HomeWindow : Window
    {
        public HomeWindow()
        {
            InitializeComponent();
            NavFrame.Navigate(new BiomaterialAcceptance());
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            WindowService windowService = new WindowService();
            windowService.OpenAuthWindow(new AuthorizeWindowViewModel());
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (DataContext is HomeViewModel vm)
            {
                vm.CloseWindowAction += () =>
                {
                    this.Close();
                };
            }
        }

        private void ShowBioPage_Click(object sender, RoutedEventArgs e)
        {
            NavFrame.Navigate(new BiomaterialAcceptance());
        }
    }
}
