using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceMtk_P2_20180140041
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Matematika : IMatematika
    {
        int IMatematika.Bagi(int a, int b)
        {
            return a / b;
        }

        int IMatematika.Kali(int a, int b)
        {
            return a * b;
        }

        int IMatematika.Kurang(int a, int b)
        {
            return a - b;
        }

        int IMatematika.Tambah(int a, int b)
        {
            return a + b;
        }

        Koordinat IMatematika.TKoordinat(Koordinat a, Koordinat b)
        {
            Koordinat hasil = new Koordinat();
            hasil.X = a.X + b.X;
            hasil.Y = a.Y + b.Y;
            return hasil;

        }
    }
}
