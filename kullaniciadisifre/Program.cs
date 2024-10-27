using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kullaniciadisifre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kullanıcı adı: ");
            string kullaniciadi
            = Console.ReadLine();
            Console.WriteLine("Şifre: ");
            string sifre
            = Console.ReadLine();
            if (kullaniciadi == "admin" && sifre == "Admin_32453@")
            {
                Console.WriteLine("Giriş başarılı.");
            }
            else
            {
                Console.WriteLine("Giriş başarısız");
            }
            Console.ReadKey();
        }
    }
}
