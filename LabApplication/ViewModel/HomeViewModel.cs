using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabApplication.Model;
using LabApplication.Misc;
using LabApplication.Services;
using LabApplication.Commands;
using System.Diagnostics;
namespace LabApplication.ViewModel
{
    public class HomeViewModel : BaseViewModel
    {
        private string currentUserName = CurrentAccount.CurrentUser?.UserName;
        private RelayCommand logoutCommand;
        public Action CloseWindowAction { get; set; }
        public string CurrentUserName
        {
            get => currentUserName;
            set => SetPropertyChanged(ref currentUserName, value);
        }
        private string currentUserRole = CurrentAccount.CurrentUser?.UserRole.GetDescription();
        public string CurrentUserRole
        {
            get => currentUserRole;
            set => SetPropertyChanged(ref currentUserRole, value);
        }

        public RelayCommand Logout => logoutCommand ??
            (logoutCommand = new RelayCommand(obj =>
            {
                try
                {
                    CurrentAccount.CurrentUser = null;

                    // Закрываем окно. В ивенте на закртие окна откроется окно авторизации
                    CloseWindowAction();
                }
                catch (Exception exception)
                {
                    Debug.WriteLine(exception.Message);
                }
            }));
    }
}
