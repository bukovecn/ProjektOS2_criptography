using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace os2_projekt
{
    class RSA
    {
        FileRW file = new FileRW();

        RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(2048);

        public byte[] cryptoRsa(byte[] originalText)
        {
            if ((file.fileExists(@"..\..\..\Files\javni_kljuc.txt") && (file.fileExists(@"..\..\..\Files\privatni_kljuc.txt"))))
            {
                StreamReader sr = new StreamReader(@"..\..\..\Files\javni_kljuc.txt");
                string publicKey = sr.ReadToEnd();
                sr.Close();

                byte[] enc = rsa.Encrypt(originalText, false);
                return enc;
            }
            else
            {
                WriteToFile();

                StreamReader sr1 = new StreamReader(@"..\..\..\Files\javni_kljuc.txt");
                string publicKey = sr1.ReadToEnd();
                sr1.Close();

                byte[] enc1 = rsa.Encrypt(originalText, false);
                string convert = System.Convert.ToBase64String(enc1, 0, enc1.Length);
                file.createFile("RSA_kriptirani_tekst", convert);
                return enc1;
            }
        }

        public void WriteToFile()
        {
            RSACryptoServiceProvider rsaCrypto = new RSACryptoServiceProvider();
            TextWriter sw = new StreamWriter(@"..\..\..\Files\javni_kljuc.txt");
            string publicKey = rsaCrypto.ToXmlString(false);
            string publicK = publicKey.ToString();
            sw.Write(publicK);
            sw.Close();

            sw = new StreamWriter(@"..\..\..\Files\privatni_kljuc.txt");
            string privateKey = rsaCrypto.ToXmlString(true);
            string privateK = privateKey.ToString();
            sw.Write(privateK);
            sw.Close();


        }

        public byte[] decryptRsa(byte[] encryptedText)
        {
            try
            {
                StreamReader stream = new StreamReader(@"..\..\..\Files\privatni_kljuc.txt");
                string privateKey = stream.ReadToEnd();
                stream.Close();

                byte[] dec = rsa.Decrypt(encryptedText, false);
                return dec;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), "POZOR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                byte[] array = new byte[1];
                return array;
            }
        }
    }
}
