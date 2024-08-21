
using Polymorphism;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Polymorphism ile şekil nesneleri oluşturuluyor
        BaseGeometrikSekil kare = new Kare(5);
        BaseGeometrikSekil dikdortgen = new Dikdortgen(4, 7);
        BaseGeometrikSekil dikUcgen = new DikUcgen(3, 6);

        // Her bir nesnenin alanını hesaplayarak konsola yazdırıyoruz
        Console.WriteLine($"Kare Alanı: {kare.AlanHesapla()}");
        Console.WriteLine($"Dikdörtgen Alanı: {dikdortgen.AlanHesapla()}");
        Console.WriteLine($"Dik Üçgen Alanı: {dikUcgen.AlanHesapla()}");
    }
}