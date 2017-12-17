using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FileHash
{
    class Crypto
    {
        public bool ComputeMD5(string l_filePath, ref byte[] l_hash)
        {
            bool l_ret = false;

            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(l_filePath))
                {
                    l_hash = md5.ComputeHash(stream);
                    l_ret = true;
                }
            }

            return l_ret;
        }

        public bool  ComputeSHA1(string l_filePath, ref byte[] l_hash)
        {
            bool l_ret = false;

            using (var sha1 = SHA1.Create())
            {
                using (var stream = File.OpenRead(l_filePath))
                {
                    l_hash = sha1.ComputeHash(stream);
                    l_ret = true;
                }
            }

            return l_ret;
        }

        public bool ComputeSHA256(string l_filePath, ref byte[] l_hash)
        {
            bool l_ret = false;

            using (var sha256 = SHA256.Create())
            {
                using (var stream = File.OpenRead(l_filePath))
                {
                    l_hash = sha256.ComputeHash(stream);
                    l_ret = true;
                }
            }

            return l_ret;
        }
    }
}
