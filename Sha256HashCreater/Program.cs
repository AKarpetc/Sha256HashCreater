using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Sha256HashCreater
{
    public static class Program
    {
        public static void Main()
        {


            var guid = Guid.NewGuid().ToString();

            Console.WriteLine("Key: " + guid);

            var hash = Sha256(guid);

            Console.WriteLine("Hash: " + hash);

       

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadLine();


        }

        public static string Sha256(string input)
        {
            if (string.IsNullOrEmpty(input)) return string.Empty;

            using (var sha = SHA256.Create())
            {
                var bytes = Encoding.UTF8.GetBytes(input);
                var hash = sha.ComputeHash(bytes);

                return Convert.ToBase64String(hash);
            }
        }
    }


}
