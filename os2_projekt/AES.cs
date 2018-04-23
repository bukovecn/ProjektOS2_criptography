using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace os2_projekt
{
    class AES
    {
        FileRW file = new FileRW();

        public byte[] cryptoAes(byte[] originalText)
        {
            RijndaelManaged aes = new RijndaelManaged();

            if (file.fileExists(@"..\..\..\Files\tajni_kljuc.txt"))
            {

                string key = file.readFile("tajni_kljuc");
                byte[] convert = System.Convert.FromBase64String(key);
                aes.KeySize = 256;
                aes.BlockSize = 128;
                aes.Key = convert;

                aes.Mode = CipherMode.ECB;

                using (MemoryStream memoryStream = new MemoryStream()) {
                    using (CryptoStream crypto = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        crypto.Write(originalText, 0, originalText.Length);
                    }
                    return memoryStream.ToArray();
                }
            }
            else
            {
                aes.BlockSize = 128;
                aes.KeySize = 256;
                aes.Mode = CipherMode.ECB;

                byte[] secretKey = aes.Key;
                string secret = System.Convert.ToBase64String(secretKey, 0, secretKey.Length);

                file.createFile("tajni_kljuc", secret);

                using(MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(originalText, 0, originalText.Length);
                    }
                    return memoryStream.ToArray();
                }
            }
               

        }

        public byte[] decryptAes(byte[] encriptedText) 
        {
            try
            {
                RijndaelManaged aes = new RijndaelManaged();
                string key = file.readFile("tajni_kljuc");
                byte[] convert = System.Convert.FromBase64String(key);

                aes.BlockSize = 128;
                aes.KeySize = 256;
                aes.Key = convert;
                aes.Mode = CipherMode.ECB;

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using(CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(encriptedText, 0, encriptedText.Length);
                    
                    }
                    return memoryStream.ToArray();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), "Pozor!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                byte[] array = new byte[1];
                return array;
            }
        }
    }
}
