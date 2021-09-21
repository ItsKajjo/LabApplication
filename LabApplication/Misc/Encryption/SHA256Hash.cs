using System;
using System.Security.Cryptography;
using System.Text;

namespace LabApplication.Misc.Encryption
{
    /// <summary>
    /// Генерирует SHA256 хеш
    /// </summary>
    public static class SHA256Hash
    {
        /// <summary>
        /// Возвращает SHA256 хеш строки
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetSHA256Hash(this string value)
        {
            StringBuilder sb = new StringBuilder();

            using (SHA256 hash = SHA256.Create())
            {
                byte[] result = hash.ComputeHash(Encoding.UTF8.GetBytes(value));

                foreach (byte b in result)
                {
                    sb.Append(b.ToString("x2"));
                }
            }

            return sb.ToString();
        }
    }
}
