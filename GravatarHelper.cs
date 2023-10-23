using System;
using System.Net;
using System.Security.Cryptography;
using System.Text;


namespace Employee_Management_System
{
    public class GravatarHelper
    {
        public static string GetGravatarUrl(string email, int size = 80)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] emailBytes = Encoding.UTF8.GetBytes(email.ToLower());
                byte[] hashBytes = md5.ComputeHash(emailBytes);

                StringBuilder builder = new StringBuilder();

                foreach (byte hashByte in hashBytes)
                {
                    builder.Append(hashByte.ToString("x2"));
                }

                string hash = builder.ToString();

                return $"https://www.gravatar.com/avatar/{hash}?s={size}";
            }
        }
    }
}



