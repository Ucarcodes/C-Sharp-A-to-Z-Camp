using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorMethod
{
    internal class UserInfo
    {
        public UserInfo(string kullaniciAdi, string kullaniciSoyadi, int kullaniciYasi, string kullaniciMeslegi)
        {

            Console.WriteLine("\n");
            Console.WriteLine("Kullanıcı Adı: " + kullaniciAdi);
            Console.WriteLine("Kullanıcı Soyadı: " + kullaniciSoyadi);
            Console.WriteLine("Kullanıcı Yaşı: " + kullaniciYasi);
            Console.WriteLine("Kullanıcı Mesleği: " + kullaniciMeslegi);
        }
    }
}
