using System;
using System.Collections.Generic;
using LabApplication.Commands;
using LabApplication.Misc.Encryption;
using LabApplication.Model;
using LabApplication.Services;
using LabApplication.View;

namespace LabApplication.ViewModel
{
    public class AuthorizeWindowViewModel : BaseViewModel
    {
        private RelayCommand loginCommand;
        public WindowService WindowService;
        public Action HideWindowAction { get; set; }
        

        private string userName;
        public string UserName
        {
            get => userName;
            set => SetPropertyChanged(ref userName, value);
        }

        private string password;
        public string Password
        {
            get => password;
            set => SetPropertyChanged(ref password, value);
        }

        private bool invalidAuth = false;
        public bool InvalidAuth
        {
            get => invalidAuth;
            set => SetPropertyChanged(ref invalidAuth, value);
        }

        public RelayCommand LoginCommand => loginCommand ??
            (loginCommand = new RelayCommand(obj =>
            {
                Login();
            }));
        public void Login()
        {
            if (!string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(Password))
            {
                foreach (User user in Users.UsersList)
                {
                    if (UserName == user.Login && SHA256Hash.GetSHA256Hash(Password) == user.HashedPassword)
                    {
                        CurrentAccount.CurrentUser = user;

                        HideWindowAction();

                        WindowService = new WindowService();
                        WindowService.OpenHomeWindow(new HomeViewModel());

                        return;
                    }
                }
            }
            InvalidAuth = true;
        }
    }
}
