using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace os2_projekt
{
    class potpis
    {
        public RSAPKCS1SignatureFormatter signatures;
        public RSAPKCS1SignatureDeformatter rsaPk;
        public SHA1Managed sha;
        public RSACryptoServiceProvider rsa;
        public RSACryptoServiceProvider rsaCrypto;

        public potpis(SHA1Managed sha1, RSACryptoServiceProvider rsa1)
        {
            sha = sha1;
            rsa = rsa1;

            signatures = new RSAPKCS1SignatureFormatter(rsa);
            rsaCrypto = new RSACryptoServiceProvider();
            signatures.SetHashAlgorithm("SHA1");
        }

        public byte[] digitalSignature(Byte[] hash)
        {
            return signatures.CreateSignature(hash);
        }

        public bool checkSignature(byte[] hash, byte[] signed) 
        {
            RSAParameters param = rsa.ExportParameters(false);
            rsaCrypto.ImportParameters(param);
            rsaPk = new RSAPKCS1SignatureDeformatter(rsaCrypto);
            rsaPk.SetHashAlgorithm("SHA1");

            try
            {
                if (rsaPk.VerifySignature(hash, signed) == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), "POZOR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
