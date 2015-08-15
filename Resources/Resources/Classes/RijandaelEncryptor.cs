using System;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using System.Text.RegularExpressions;

namespace Resources
{
    public class RijandaelEncryptor
    {
        internal const string InputKey = "87D235B6-DA8C-4A5E-A51B-D15B1D1A9B5D";
        internal const string SaltKey = "6446F0CE-705A-4C6C-A2A4-BDA51B5560A8";
        public static string Encrypt(string text)
        {
            if (string.IsNullOrEmpty(text))
                throw new ArgumentNullException("String is empty or null");
            var aesAlg = NewRijandelManaged();
            var encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
            var msEncrypt = new MemoryStream();
            using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
            using (var swEncrypt = new StreamWriter(csEncrypt))
            {
                swEncrypt.Write(text);
            }

            return Convert.ToBase64String(msEncrypt.ToArray());
        }

        public static string Decrypt(string cipherText)
        {
            if (string.IsNullOrEmpty(cipherText))
                throw new ArgumentNullException("cipherText");
            if (!IsBase64String(cipherText))
                throw new Exception("The cipherText input parameter is not base64 encoded");
            string text;
            var aesAlg = NewRijandelManaged();
            var decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
            var cipher = Convert.FromBase64String(cipherText);
            using (var msDecript = new MemoryStream(cipher))
            {
                using (var csDecrypt = new CryptoStream(msDecript, decryptor, CryptoStreamMode.Read))
                {
                    using (var srDecrypt = new StreamReader(csDecrypt))
                    {
                        text = srDecrypt.ReadToEnd();
                    }
                }
            }
            return text;
        }

        public static bool IsBase64String(string base64String)
        {
            base64String = base64String.Trim();
            return (base64String.Length % 4 == 0) && Regex.IsMatch(base64String, @"^[a-zA-Z0-9\+/]*={0,3}$", RegexOptions.None);
        }

        private static RijndaelManaged NewRijandelManaged()
        {
            if (SaltKey == null)
                throw new ArgumentNullException("Salt is null");
            var saltBytes = Encoding.ASCII.GetBytes(SaltKey);
            var key = new Rfc2898DeriveBytes(InputKey, saltBytes);
            var aesAlg = new RijndaelManaged();
            aesAlg.Key = key.GetBytes(aesAlg.KeySize / 8);
            aesAlg.IV = key.GetBytes(aesAlg.BlockSize / 8);
            return aesAlg;
        }

    }
}



