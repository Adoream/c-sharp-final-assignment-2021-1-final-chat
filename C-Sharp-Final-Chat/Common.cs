using System;
using System.Security.Cryptography;
using System.Text;

namespace C_Sharp_Final_Chat
{
    public class Common
    {
        public static Tuple<string, string> GenerateRsaKeys()
        {
            var rsa = new RSACryptoServiceProvider();

            var publicKey = rsa.ToXmlString(false);
            var privateKey = rsa.ToXmlString(true);

            return Tuple.Create(publicKey, privateKey);
        }

        public static string EncryptData(string publicKey, string content)
        {
            var rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(publicKey);

            var encryptString = Convert.ToBase64String(rsa.Encrypt(Encoding.UTF8.GetBytes(content), false));

            return encryptString;
        }

        public static string DecryptData(string privateKey, string encryptedContent)
        {
            var rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(privateKey);

            var decryptString = Encoding.UTF8.GetString(rsa.Decrypt(Convert.FromBase64String(encryptedContent), false));

            return decryptString;
        }
    }
}