using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesForm
{
    internal class DriverInfo
    {

        public string kullaniciAdi, kullaniciSoyAdi;
        public int kullaniciYasi;

        public int kullaniciYasiABS
        {
            get { return kullaniciYasi; }
            set { kullaniciYasi = Math.Abs(value); } //Negatif yaş girişini önledik.
        }
    }
}
