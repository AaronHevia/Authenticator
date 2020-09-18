using System;

namespace Authenticator
{
    class Encryption
    {
        public string Encrypt(string password)
        {
            int i = 0;
            string encrypted = "";


            foreach (char c in password)
            {
                i++;
                char encryption = (char)(c * i);
                encrypted += encryption.ToString();
            }

            return encrypted;
        }
    }
}