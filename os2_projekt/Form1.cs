using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace os2_projekt
{
    public partial class Form1 : Form
    {

        FileRW file = new FileRW();
        AES aes = new AES();
        RSA rsa = new RSA();
        sazetak sazetakPor = new sazetak();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnKriptiraj_Click(object sender, EventArgs e)
        {
            if(radioSim.Checked == false && radioAntisim.Checked == false)
            {
                MessageBox.Show("Morate odabarati vrstu kriptosustava (simetrični / antisimetrični)!");
            }
            else
            {
                string dat = file.readFile("tekst");

                if(radioSim.Checked == true && radioAntisim.Checked == false)
                {
                    //simetrično kriptiraj
                    if(String.Compare(dat, "false") == 0)
                    {
                        MessageBox.Show("Ne postoji datoteka s tekstom!", "POZOR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        orgTxt.Text = dat;
                        byte[] aesData = Encoding.UTF8.GetBytes(dat);
                        byte[] encriptedText = aes.cryptoAes(aesData);
                        string convert = System.Convert.ToBase64String(encriptedText, 0, encriptedText.Length);
                        cryptoTxt.Text = convert;
                        file.createFile("AES_kriptirani_tekst", convert);
                    }
                }
                else
                {
                    //antisimetrično kriptiraj
                    if (String.Compare(dat, "false") == 0)
                    {
                        MessageBox.Show("Ne postoji datoteka s tekstom!", "POZOR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        orgTxt.Text = dat;
                        byte[] rsaData = Encoding.UTF8.GetBytes(dat);
                        byte[] encriptedText = rsa.cryptoRsa(rsaData);
                        string convert = System.Convert.ToBase64String(encriptedText, 0, encriptedText.Length);
                        cryptoTxt.Text = convert;
                        file.createFile("RSA_kriptirani_tekst", convert);
                    }
                }
            }
        }

        private void btnDekriptiraj_Click(object sender, EventArgs e)
        {
            if (radioSim.Checked == false && radioAntisim.Checked == false)
            {
                MessageBox.Show("Morate odabarati vrstu kriptosustava (simetrični / antisimetrični)!");
            }
            else
            {
                if (radioSim.Checked == true)
                {
                    //simetrično dekriptiraj
                    byte[] convertTo;

                    if (file.fileExists(@"..\..\..\Files\AES_kriptirani_teks.txt"))
                    {
                        convertTo = System.Convert.FromBase64String(file.readFile("AES_kriptirani_tekst"));
                        byte[] decryptedText = aes.decryptAes(convertTo);
                        string decrypt = System.Text.Encoding.UTF8.GetString(decryptedText);
                        cryptoTxt.Text = decrypt;
                    }
                    else
                    {
                        convertTo = System.Convert.FromBase64String(cryptoTxt.Text);
                        byte[] decryptedText = aes.decryptAes(convertTo);
                        string decrypt = System.Text.Encoding.UTF8.GetString(decryptedText);
                        cryptoTxt.Text = decrypt;
                    }
                }
                else
                {
                    //antisimetrično dekriptiraj
                    byte[] convertTo;
                    if (file.fileExists(@"..\..\..\Files\RSA_kriptirani_teks.txt"))
                    {
                        convertTo = System.Convert.FromBase64String(file.readFile("RSA_kriptirani_tekst"));
                        byte[] decryptedText = rsa.decryptRsa(convertTo);
                        string decrypt = System.Text.Encoding.UTF8.GetString(decryptedText);
                        cryptoTxt.Text = decrypt;
                    }
                    else
                    {
                        convertTo = System.Convert.FromBase64String(cryptoTxt.Text);
                        byte[] decryptedText = rsa.decryptRsa(convertTo);
                        string decrypt = System.Text.Encoding.UTF8.GetString(decryptedText);
                        cryptoTxt.Text = decrypt;
                    }
                }
            }
        }

        private void btnSazetak_Click(object sender, EventArgs e)
        {
            string dat = file.readFile("tekst");

            byte[] hash = Encoding.ASCII.GetBytes(dat);
            txtSazetak.Text = sazetakPor.makeHash(hash);
            file.createFile("sazetak", txtSazetak.Text);
        }

        private void btnPotpis_Click(object sender, EventArgs e)
        {
            potpis p = new potpis(new SHA1Managed(), new RSACryptoServiceProvider());
            StreamReader sr = new StreamReader(@"..\..\..\Files\privatni_kljuc.txt");
            p.rsa.FromXmlString(sr.ReadToEnd());
            string data = file.readFile("tekst");
            byte[] hash = Encoding.UTF8.GetBytes(data);
            byte[] Bhash = p.digitalSignature(p.sha.ComputeHash(hash));
            string final = Encoding.UTF8.GetString(Bhash);
            MessageBox.Show("Digitalni potpis: " + Convert.ToBase64String(Bhash));

            file.writeIntoFile("digitalni_potpis", Bhash);
        }

        private void btnProvjera_Click(object sender, EventArgs e)
        {
            potpis p = new potpis(new SHA1Managed(), new RSACryptoServiceProvider());
            StreamReader reader = new StreamReader(@"..\..\..\Files\javni_kljuc.txt");
            string hash = file.readFile("tekst");
            byte[] Bhash = Encoding.UTF8.GetBytes(hash);
            byte[] hashing = p.sha.ComputeHash(Bhash);
            p.rsa.FromXmlString(reader.ReadToEnd());


            if (p.checkSignature(hashing, (file.readFrom("digitalni_potpis"))) == true)
            { 
                MessageBox.Show("Digitalni potpis je ispravan!", "Uspješno!");
            }
            else
            {
                MessageBox.Show("Digitalni potpis neispravan!", "POZOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }
    }

}
