using System;
using System.Security.Cryptography;
/*
 * Name:Mark Xie
 * Student Id:p447119
 * Date:11/11/2019
 * Programming III
 */
namespace MusicPlayer_Project
{
    class Hash
    {
        private RNGCryptoServiceProvider m_cryptoServiceProvider = new RNGCryptoServiceProvider();
        private int SALT_SIZE = 24;

        //function to convert string to byte[]
        public static byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        //function to generate 24 random value
        public string GetSaltString()
        {
            byte[] randomBytes = new byte[SALT_SIZE];
            m_cryptoServiceProvider.GetBytes(randomBytes);
            return Convert.ToBase64String(randomBytes);

        }

        public string GetPasswordHashAndSalt(string message)
        {
            // Let us use SHA256 algorithm to
            // generate the hash from this salted password
            SHA256 sha = new SHA256CryptoServiceProvider();
            byte[] dataBytes = GetBytes(message);
            byte[] resultBytes = sha.ComputeHash(dataBytes);
            return Convert.ToBase64String(resultBytes);
        }

        public string GeneratePasswordHash(string plainTextPassword)
        {
            string salt = GetSaltString();
            string finalString = plainTextPassword + salt;
            string hashedPassword = GetPasswordHashAndSalt(finalString);
            return hashedPassword + "|" + salt;
        }

        public bool IsPasswordMatch(string password, string salt, string hash)
        {
            string finalString = password + salt;
            string hashedPassword = GetPasswordHashAndSalt(finalString);
            return hash == hashedPassword;
        }
    }
}
