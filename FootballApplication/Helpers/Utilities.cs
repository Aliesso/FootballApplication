using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FootballApplication
{
    static class Utilities
    {
        public static bool isEmpty(string[] arr)
        {
            foreach (var item in arr)
            {
                if (string.IsNullOrWhiteSpace(item))
                {
                    return false;
                }
            }
            return true;
        }
        public static string HashMe(this string pas)
        {
            byte[] hashByte = new ASCIIEncoding().GetBytes(pas);
            byte[] hashPass = new SHA256Managed().ComputeHash(hashByte);
            string newPass = new ASCIIEncoding().GetString(hashPass);
            return newPass;
        }
    }
}
