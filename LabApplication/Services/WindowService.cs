using LabApplication.View;
using LabApplication.ViewModel;

namespace LabApplication.Services
{
    /// <summary>
    /// Открывает окна
    /// </summary>
    public class WindowService
    {
        public void OpenHomeWindow(HomeViewModel vm)
        {
            HomeWindow homeWindow = new HomeWindow
            {
                DataContext = vm
            };
            homeWindow.Show();
        }
        public void OpenAuthWindow(AuthorizeWindowViewModel vm)
        {
            AuthorizeWindow authWindow = new AuthorizeWindow
            {
                DataContext = vm
            };
            authWindow.Show();
        }
    }
}
