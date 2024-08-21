using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class BaseGeometrikSekil
    {
        public double Genislik { get; set; }
        public double Yukseklik { get; set; }

        // Alan hesaplama metodu, türetilen sınıflarda override edilebilir
        public virtual double AlanHesapla()
        {
            return Genislik * Yukseklik;
        }
    }

    public class Kare : BaseGeometrikSekil
    {
        public Kare(double kenar)
        {
            Genislik = kenar;
            Yukseklik = kenar;
        }

        // Kare için alan hesaplama
        public override double AlanHesapla()
        {
            return Genislik * Yukseklik;
        }
    }

    public class Dikdortgen : BaseGeometrikSekil
    {
        public Dikdortgen(double genislik, double yukseklik)
        {
            Genislik = genislik;
            Yukseklik = yukseklik;
        }

        // Dikdörtgen için alan hesaplama
        public override double AlanHesapla()
        {
            return Genislik * Yukseklik;
        }
    }

    public class DikUcgen : BaseGeometrikSekil
    {
        public DikUcgen(double genislik, double yukseklik)
        {
            Genislik = genislik;
            Yukseklik = yukseklik;
        }

        // Dik Üçgen için alan hesaplama
        public override double AlanHesapla()
        {
            return (Genislik * Yukseklik) / 2;
        }
    }
}
