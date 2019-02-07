using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace eCTD_indexer.XML
{
    public static class SHA256
    {
        // See also https://stackoverflow.com/questions/1177607/what-is-the-fastest-way-to-create-a-checksum-for-large-files-in-c-sharp/1177744
        public static string GetChecksum(string file)
        {
            if (File.Exists(file))
            {
                using (FileStream stream = File.OpenRead(file))
                {
                    SHA256Managed sha = new SHA256Managed();
                    byte[] checksum = sha.ComputeHash(stream);
                    return BitConverter.ToString(checksum).Replace("-", String.Empty);

                }
            } else
            { return "-1"; }

        }
    }
}
