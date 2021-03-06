﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LİNQ
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Veri
            List<Ogrenci> Ogrenciler = new List<Ogrenci>()
            {
                new Ogrenci{Id = 1, Adi = "Ömer", Soyadi = "Abanuzoğlu", DogumTarihi = new DateTime(1999,10,13)},
                new Ogrenci{Id = 2, Adi = "Mustafa", Soyadi = "Abanuzoğlu", DogumTarihi = new DateTime(2002,11,29)},
                new Ogrenci{Id = 3, Adi = "KAlimcan", Soyadi = "Kalfa", DogumTarihi = new DateTime(1998,8,17)},
                new Ogrenci{Id = 4, Adi = "Yusuf", Soyadi = "Konur", DogumTarihi = new DateTime(1999,10,5)},
                new Ogrenci{Id = 5, Adi = "Uğur", Soyadi = "Karatepe", DogumTarihi = new DateTime(1999,10,26)},
                new Ogrenci{Id = 6, Adi = "Feyzullah", Soyadi = "Altınok", DogumTarihi = new DateTime(1999,1,31)},
                new Ogrenci{Id = 7, Adi = "Kadir", Soyadi = "Yağbasan", DogumTarihi = new DateTime(1999,2,7)},
                new Ogrenci{Id = 8, Adi = "Nihat", Soyadi = "Erdoğan", DogumTarihi = new DateTime(1999,7,13)},
                new Ogrenci{Id = 9, Adi = "Kadir", Soyadi = "Konur", DogumTarihi = new DateTime(1996,5,8)},
                new Ogrenci{Id = 10, Adi = "Sabri", Soyadi = "Demirci", DogumTarihi = new DateTime(1996,7,7)}
            };
            #endregion


            #region   Id'si 4 den büyük olan öğrenvileri bulalım.


            #region    Normal C#

            //List<Ogrenci> ogrs = new List<Ogrenci>();
            //foreach (var ogr in Ogrenciler)
            //{
            //    if (ogr.Id > 4)
            //    {
            //        ogrs.Add(ogr);
            //    }
            //}

            //foreach (var o in ogrs)
            //{
            //    Console.WriteLine(o.Adi);
            //}
            #endregion


            // LİNQ YÖNTEMİ

            //var query = from a in Ogrenciler
            //            where a.Id > 4
            //            select a;
            
            //foreach (var o in query)
            //{
            //    Console.WriteLine(o.Adi);
            //}



            //LAMBDA YÖNTEMİ 
            
            //var b = Ogrenciler.Where(a => a.Id > 4);
            
            //foreach (var o in b)
            //{
            //    Console.WriteLine(o.Soyadi);
            //}



            //Adının ilk harfi K olanları getir.

            //var deneme = Ogrenciler.Where(a => a.Adi[0] == 'K');
            //var deneme = Ogrenciler.Where(a => a.Adi.StartsWith("K"));
            //var deneme = Ogrenciler.Where(a => a.Adi.Substring(0,1).ToUpper() == "K");
            
            //var deneme = from a in Ogrenciler
            //             where a.Adi.Substring(0, 1).ToUpper() == "K"
            //             select a;

            //foreach (var o in deneme)
            //{
            //    Console.WriteLine(o.Adi + " " + o.Soyadi);
            //}



            //Soyadının Son Harfi u olan öğrenciler.

            //var deneme = Ogrenciler.Where(a => a.Soyadi[a.Soyadi.Length - 1] == 'n');
            //var deneme = Ogrenciler.Where(a => a.Soyadi.Substring(a.Soyadi.Length - 1, 1).ToLower() == "u");
            //var deneme = Ogrenciler.Where(a => a.Soyadi.EndsWith("n"));

            //foreach (var o in deneme)
            //{
            //    Console.WriteLine(o.Adi + " " + o.Soyadi);
            //}



            //Yaşı 22den küçük olan öğrenciler.
            //var deneme = Ogrenciler.Where(a => (DateTime.Now.Year - a.DogumTarihi.Year) < 22);

            //foreach (var o in deneme)
            //{
            //    Console.WriteLine(o.Adi +" "+o.Soyadi);
            //}



            //Id'si 4den küçük olan öğrenciler

            var deneme = Ogrenciler.Where(a => a.Id < 4);
            foreach (var o in deneme)
            {
                Console.WriteLine(o.Id +" "+ o.Adi + " "+ o.Soyadi);
            }


            #endregion
            
            Console.ReadLine();
        }
    }
}
