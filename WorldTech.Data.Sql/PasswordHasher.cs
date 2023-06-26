using System.Drawing;
using System.Security.Cryptography;

namespace WorldTech.Data.Sql
{
    public class PasswordHasher
    {
        public string HashPassword(string password)
        {
            byte[] passwordBytes = System.Text.Encoding.UTF8.GetBytes(password);

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(passwordBytes);
                return Convert.ToBase64String(hashedBytes);
            }
        }
    }
}
