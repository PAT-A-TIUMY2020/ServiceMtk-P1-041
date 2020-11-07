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
            try
            {
                return a / b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                MathFault mf = new MathFault();
                mf.Kode = "Inputan yang anda masukan salah";
                mf.Pesan = "Masukan input yang benar";
                throw new FaultException<MathFault>(mf);
            }
        }


        int IMatematika.Kali(int a, int b)
        {
            try
            {


                return a * b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                MathFault mf = new MathFault();
                mf.Kode = "Inputan yang anda masukan salah";
                mf.Pesan = "Masukan input yang benar";
                throw new FaultException<MathFault>(mf);
            }
        }

        int IMatematika.Kurang(int a, int b)
        {
            try
            {

                return a - b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                MathFault mf = new MathFault();
                mf.Kode = "Inputan yang anda masukan salah";
                mf.Pesan = "Masukan input yang benar";
                throw new FaultException<MathFault>(mf);
            }
        }

        int IMatematika.Tambah(int a, int b)
        {
            try
            {


                return a + b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                MathFault mf = new MathFault();
                mf.Kode = "Inputan yang anda masukan salah";
                mf.Pesan = "Masukan input yang benar";
                throw new FaultException<MathFault>(mf);
            }
        }

        Koordinat IMatematika.TKoordinat(Koordinat a, Koordinat b)
        {
            try
            {


                Koordinat hasil = new Koordinat();
                hasil.X = a.X + b.X;
                hasil.Y = a.Y + b.Y;
                return hasil;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                MathFault mf = new MathFault();
                mf.Kode = "Inputan yang anda masukan salah";
                mf.Pesan = "Masukan input yang benar";
                throw new FaultException<MathFault>(mf);
            }

        }
    }
}
