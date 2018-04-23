using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace os2_projekt
{
    class sazetak
    {
        public string makeHash(byte[] file)
        {
            using(SHA1Managed sha = new SHA1Managed())
            {
                var hashing = sha.ComputeHash(file);
                string convert = Convert.ToBase64String(hashing);
                return convert;
            }
        }
    }
}
