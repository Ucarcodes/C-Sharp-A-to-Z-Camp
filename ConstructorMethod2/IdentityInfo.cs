using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorMethod2
{
    internal class IdentityInfo
    {

        string ad;
        string soyad;
        string memleket;
        string cinsiyet;
        int yas;

        public string adLower
        {
            get { return ad; }
            set { ad = value.ToLower(); }
        }

        public string soyadUpper
        {
            get { return soyad; }
            set { soyad = value.ToUpper(); }
        }

        public string memleketCapsule
        {
            get { return memleket; }
            set { memleket = value; }
        }

        public string cinsiyetCapsule
        {
            get { return cinsiyet; }
            set { cinsiyet = value; }

        }

        public int yasCapsule
        {
            get { return yas; }
            set { yas = value; }
        }

        public IdentityInfo()
        {
            ad = "Lütfen ad giriniz.";
            soyad = "Lütfen soyad giriniz.";
            memleket = "Lütfen memleket giriniz.";
            cinsiyet = "Lütfen cinsiyet giriniz.";
            yas = 18;

        }



    }
}
