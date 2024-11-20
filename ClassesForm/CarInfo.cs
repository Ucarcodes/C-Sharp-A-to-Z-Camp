using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesForm
{
    internal class CarInfo: DriverInfo
    {
        public string marka, model, renk;
        public double hacim;

        public string markaUpper
        {
            get { return marka; }
            set { marka = value.ToUpper(); } //Marka adını büyük harflerle yazdırdık.
        }

        public double hacimABS
        {
            get { return hacim; }
            set { hacim = Math.Abs(value); } //Negatif hacim girişini önledik.
        }
    }
}
