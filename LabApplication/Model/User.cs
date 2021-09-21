using LabApplication.Misc.Encryption;

namespace LabApplication.Model
{
    /// <summary>
    /// Представляет собой класс пользователя. Где хранится его логин, хеш пароля, имя и роль
    /// </summary>
    public class User
    {
        private string _hashedPassword;
        public string HashedPassword
        {
            get => _hashedPassword;
            set => _hashedPassword = value.GetSHA256Hash();
        }
        public string Login { get; set; }
        public string UserName { get; set; }
        public Role UserRole;
        public User(string login, string password, string userName, Role role)
        {
            Login = login;
            HashedPassword = password;
            UserName = userName;
            UserRole = role; 
        }
    }
}
