using ComicBookFactories;
using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace DataAccess
{
    public class sqlLogin : ILoginRepo
    {
        public int LoginUser(string username, string password)
        {
            var sqlLogin = "Select Count(*) FROM Login WHERE @Username = Username AND @Password = password";
            var cmd = new SqlCommand(sqlLogin);
            cmd.Parameters.AddWithValue("@Username", username);
            var encryptedPassword = encrypt(password);
            cmd.Parameters.AddWithValue("@Password", encryptedPassword);

            var rowsAffected = DataAccess.GetValue(cmd);

            return Convert.ToInt32(rowsAffected);

        }
        public int RegisterUser(string username, string password)
        {
            var sqlRegister = "Insert Into Login VALUES (@Username,@Password)";
            var cmd = new SqlCommand(sqlRegister);
            cmd.Parameters.AddWithValue("@Username", username);
            var encryptedPassword = encrypt(password);
            cmd.Parameters.AddWithValue("@Password", encryptedPassword);

            var rowsAffected = DataAccess.ExecuteNonQuery(cmd);

            return rowsAffected;
        }

        public string encrypt(string password)
        {
            var encryptedPassword = string.Empty;

            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] data = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                var sBuilder = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }

                encryptedPassword = sBuilder.ToString();
            }
            return encryptedPassword;
        }
    }
}
